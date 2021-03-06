﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using YouTrack.Rest.Factories;
using YouTrack.Rest.Interception;

namespace YouTrack.Rest.Tests.Factories
{
    class IssueFactoryTests : TestFor<IssueFactory>
    {
        private const string IssueId = "FOO-BAR";

        [Test]
        public void IssueProxyIsCreated()
        {
            IIssue issue = Sut.CreateIssue(IssueId, Mock<IConnection>());

            Assert.That(issue.GetType().Name, Is.EqualTo("IIssueProxy"));
        }

        [Test]
        public void IssueIdIsAssigned()
        {
            IIssue issue = Sut.CreateIssue(IssueId, Mock<IConnection>());

            Assert.That(issue.Id, Is.EqualTo(IssueId));
        }
    }
}
