﻿using System.Threading.Tasks;
using Ardalis.GuardClauses;
using NEWPROJECT_CleanArchitecture.Core.Events;
using NEWPROJECT_CleanArchitecture.Core.Interfaces;
using NEWPROJECT_CleanArchitecture.SharedKernel.Interfaces;

namespace NEWPROJECT_CleanArchitecture.Core.Services
{
    public class ItemCompletedEmailNotificationHandler : IHandle<ToDoItemCompletedEvent>
    {
        private readonly IEmailSender _emailSender;

        public ItemCompletedEmailNotificationHandler(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        // configure a test email server to demo this works
        // https://ardalis.com/configuring-a-local-test-email-server
        public async Task Handle(ToDoItemCompletedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            await _emailSender.SendEmailAsync("test@test.com", "test@test.com", $"{domainEvent.CompletedItem.Title} was completed.", domainEvent.CompletedItem.ToString());
        }
    }
}
