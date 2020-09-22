﻿using AutoFixture.Idioms;
using AutoFixture.Xunit2;
using SoftwareHut.HubspotService.Test.Attributes;
using Xunit;

namespace SoftwareHut.HubspotService.Test.Deserialize
{
    public abstract class BaseAssertion<T> where T : class
    {
        [Theory]
        [AutoFakeData]
        public virtual void SutHasGuardClauses(GuardClauseAssertion guardClauseAssertion)
        {
            guardClauseAssertion.Verify(typeof(T));
        }

        [Theory]
        [AutoFakeData]
        public virtual void SutCtorInitializesMembers(ConstructorInitializedMemberAssertion assertion)
        {
            assertion.Verify(typeof(T));
        }
    }
}