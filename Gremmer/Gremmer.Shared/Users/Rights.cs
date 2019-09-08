using System;

namespace Gremmer.Shared.Users
{
    /// <summary>
    /// Those are the standard staffrights. Default and moderator rights are still bound to the pages they have access to.
    /// </summary>
    [Flags]
    public enum Rights
    {
        Default = 0,
        Moderator = 1,
        Administrator = 2,
        AllPermissions = 4
    }
}
