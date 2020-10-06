﻿using System.Threading.Tasks;

namespace NEWPROJECT_CleanArchitecture.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
