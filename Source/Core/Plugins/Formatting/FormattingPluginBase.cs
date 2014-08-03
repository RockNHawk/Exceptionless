﻿using System;
using Exceptionless.Core.Models;
using Exceptionless.Core.Queues.Models;
using Exceptionless.Models;

namespace Exceptionless.Core.Plugins.Formatting {
    public abstract class FormattingPluginBase : IFormattingPlugin {
        public virtual SummaryData GetStackSummary(PersistentEvent ev) {
            return null;
        }

        public virtual SummaryData GetEventSummary(PersistentEvent ev) {
            return null;
        }

        public virtual string GetStackTitle(PersistentEvent ev) {
            return null;
        }

        public virtual MailMessage GetEventNotificationMailMessage(EventNotification model) {
            return null;
        }

        public virtual string GetEventViewName(PersistentEvent ev) {
            return null;
        }
    }
}