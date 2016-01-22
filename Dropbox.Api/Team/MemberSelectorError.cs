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
    /// <para>The member selector error object</para>
    /// </summary>
    public class MemberSelectorError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberSelectorError> Encoder = new MemberSelectorErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberSelectorError> Decoder = new MemberSelectorErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberSelectorError" />
        /// class.</para>
        /// </summary>
        public MemberSelectorError()
        {
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

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberSelectorError" />.</para>
        /// </summary>
        private class MemberSelectorErrorEncoder : enc.StructEncoder<MemberSelectorError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberSelectorError value, enc.IJsonWriter writer)
            {
                if (value is UserNotInTeam)
                {
                    WriteProperty(".tag", "user_not_in_team", writer, enc.StringEncoder.Instance);
                    UserNotInTeam.Encoder.EncodeFields((UserNotInTeam)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberSelectorError" />.</para>
        /// </summary>
        private class MemberSelectorErrorDecoder : enc.UnionDecoder<MemberSelectorError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberSelectorError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberSelectorError Create()
            {
                return new MemberSelectorError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MemberSelectorError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "user_not_in_team":
                        return UserNotInTeam.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The user is not a member of the team.</para>
        /// </summary>
        public sealed class UserNotInTeam : MemberSelectorError
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
    }
}
