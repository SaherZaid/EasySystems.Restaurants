using EasySystems.Restaurants.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace EasySystems.Restaurants.Services;

public class EmailSettings
{
    public string Host { get; set; } = "";
    public int Port { get; set; } = 587;
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string DisplayName { get; set; } = "EasySystems";
    public bool EnableSsl { get; set; } = true;
}

public class SmtpEmailSender : IEmailSender<ApplicationUser>
{
    private readonly EmailSettings _settings;

    public SmtpEmailSender(IOptions<EmailSettings> options)
    {
        _settings = options.Value;
    }

    public async Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
    {
        await SendEmailAsync(
            email,
            "Confirm your email",
            $"""
            <h2>Confirm your email</h2>
            <p>Welcome to EasySystems.</p>
            <p>Please confirm your email by clicking the link below:</p>
            <p><a href="{confirmationLink}">Confirm email</a></p>
            """);
    }

    public async Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
    {
        await SendEmailAsync(
            email,
            "Reset your password",
            $"""
            <h2>Reset your password</h2>
            <p>Click the link below to reset your password:</p>
            <p><a href="{resetLink}">Reset password</a></p>
            """);
    }

    public async Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
    {
        await SendEmailAsync(
            email,
            "Password reset code",
            $"""
            <h2>Password reset code</h2>
            <p>Your reset code is:</p>
            <h3>{resetCode}</h3>
            """);
    }

    private async Task SendEmailAsync(string toEmail, string subject, string htmlBody)
    {
        if (string.IsNullOrWhiteSpace(_settings.Email))
            throw new InvalidOperationException("EmailSettings:Email is missing.");

        using var message = new MailMessage
        {
            From = new MailAddress(_settings.Email, _settings.DisplayName),
            Subject = subject,
            Body = htmlBody,
            IsBodyHtml = true
        };

        message.To.Add(toEmail);

        using var client = new SmtpClient(_settings.Host, _settings.Port)
        {
            EnableSsl = _settings.EnableSsl,
            Credentials = new NetworkCredential(_settings.Email, _settings.Password)
        };

        await client.SendMailAsync(message);
    }
}