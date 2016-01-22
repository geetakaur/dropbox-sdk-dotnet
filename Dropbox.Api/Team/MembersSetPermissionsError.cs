// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The members set permissions error object</para>
    /// </summary>
    public class MembersSetPermissionsError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembersSetPermissionsError> Encoder = new MembersSetPermissionsErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembersSetPermissionsError> Decoder = new MembersSetPermissionsErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersSetPermissionsError" />
        /// class.</para>
        /// </summary>
        public MembersSetPermissionsError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is LastAdmin</para>
        /// </summary>
        public bool IsLastAdmin
        {
            get
            {
                return this is LastAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a LastAdmin, or <c>null</c>.</para>
        /// </summary>
        public LastAdmin AsLastAdmin
        {
            get
            {
                return this as LastAdmin;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UserNotInTeam</para>
        /// </summary>
        public bool IsUserNotInTeam
        {
            get
            {
                return this is UserNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserNotInTeam, or <c>null</c>.</para>
        /// </summary>
        public UserNotInTeam AsUserNotInTeam
        {
            get
            {
                return this as UserNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is CannotSetPermissions</para>
        /// </summary>
        public bool IsCannotSetPermissions
        {
            get
            {
                return this is CannotSetPermissions;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a CannotSetPermissions, or <c>null</c>.</para>
        /// </summary>
        public CannotSetPermissions AsCannotSetPermissions
        {
            get
            {
                return this as CannotSetPermissions;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MembersSetPermissionsError" />.</para>
        /// </summary>
        private class MembersSetPermissionsErrorEncoder : enc.StructEncoder<MembersSetPermissionsError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembersSetPermissionsError value, enc.IJsonWriter writer)
            {
                if (value is LastAdmin)
                {
                    WriteProperty(".tag", "last_admin", writer, enc.StringEncoder.Instance);
                    LastAdmin.Encoder.EncodeFields((LastAdmin)value, writer);
                    return;
                }
                if (value is UserNotInTeam)
                {
                    WriteProperty(".tag", "user_not_in_team", writer, enc.StringEncoder.Instance);
                    UserNotInTeam.Encoder.EncodeFields((UserNotInTeam)value, writer);
                    return;
                }
                if (value is CannotSetPermissions)
                {
                    WriteProperty(".tag", "cannot_set_permissions", writer, enc.StringEncoder.Instance);
                    CannotSetPermissions.Encoder.EncodeFields((CannotSetPermissions)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MembersSetPermissionsError" />.</para>
        /// </summary>
        private class MembersSetPermissionsErrorDecoder : enc.UnionDecoder<MembersSetPermissionsError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembersSetPermissionsError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembersSetPermissionsError Create()
            {
                return new MembersSetPermissionsError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MembersSetPermissionsError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "last_admin":
                        return LastAdmin.Decoder.DecodeFields(reader);
                    case "user_not_in_team":
                        return UserNotInTeam.Decoder.DecodeFields(reader);
                    case "cannot_set_permissions":
                        return CannotSetPermissions.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Cannot remove the admin setting of the last admin.</para>
        /// </summary>
        public sealed class LastAdmin : MembersSetPermissionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<LastAdmin> Encoder = new LastAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<LastAdmin> Decoder = new LastAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="LastAdmin" /> class.</para>
            /// </summary>
            private LastAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of LastAdmin</para>
            /// </summary>
            public static readonly LastAdmin Instance = new LastAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="LastAdmin" />.</para>
            /// </summary>
            private class LastAdminEncoder : enc.StructEncoder<LastAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(LastAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="LastAdmin" />.</para>
            /// </summary>
            private class LastAdminDecoder : enc.StructDecoder<LastAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="LastAdmin" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override LastAdmin Create()
                {
                    return new LastAdmin();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override LastAdmin DecodeFields(enc.IJsonReader reader)
                {
                    return LastAdmin.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The user is not a member of the team.</para>
        /// </summary>
        public sealed class UserNotInTeam : MembersSetPermissionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserNotInTeam> Encoder = new UserNotInTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserNotInTeam> Decoder = new UserNotInTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserNotInTeam" />
            /// class.</para>
            /// </summary>
            private UserNotInTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UserNotInTeam</para>
            /// </summary>
            public static readonly UserNotInTeam Instance = new UserNotInTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserNotInTeam" />.</para>
            /// </summary>
            private class UserNotInTeamEncoder : enc.StructEncoder<UserNotInTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserNotInTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserNotInTeam" />.</para>
            /// </summary>
            private class UserNotInTeamDecoder : enc.StructDecoder<UserNotInTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UserNotInTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserNotInTeam Create()
                {
                    return new UserNotInTeam();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override UserNotInTeam DecodeFields(enc.IJsonReader reader)
                {
                    return UserNotInTeam.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Cannot remove/grant permissions.</para>
        /// </summary>
        public sealed class CannotSetPermissions : MembersSetPermissionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<CannotSetPermissions> Encoder = new CannotSetPermissionsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<CannotSetPermissions> Decoder = new CannotSetPermissionsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CannotSetPermissions" />
            /// class.</para>
            /// </summary>
            private CannotSetPermissions()
            {
            }

            /// <summary>
            /// <para>A singleton instance of CannotSetPermissions</para>
            /// </summary>
            public static readonly CannotSetPermissions Instance = new CannotSetPermissions();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="CannotSetPermissions" />.</para>
            /// </summary>
            private class CannotSetPermissionsEncoder : enc.StructEncoder<CannotSetPermissions>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(CannotSetPermissions value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="CannotSetPermissions" />.</para>
            /// </summary>
            private class CannotSetPermissionsDecoder : enc.StructDecoder<CannotSetPermissions>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="CannotSetPermissions"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override CannotSetPermissions Create()
                {
                    return new CannotSetPermissions();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override CannotSetPermissions DecodeFields(enc.IJsonReader reader)
                {
                    return CannotSetPermissions.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>An unspecified error.</para>
        /// </summary>
        public sealed class Other : MembersSetPermissionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
