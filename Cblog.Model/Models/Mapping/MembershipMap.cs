// ----------------------------------------------------------------------
// <copyright file="MembershipMap.cs" company="cvlad">
//  MembershipMap
// </copyright>
// <author>Vladimir Ciobanu</author>
// ----------------------------------------------------------------------

namespace Cblog.Model.Models.Mapping
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// The membership map.
    /// </summary>
    public class MembershipMap : EntityTypeConfiguration<Membership>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipMap"/> class.
        /// </summary>
        public MembershipMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConfirmationToken)
                .HasMaxLength(128);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PasswordSalt)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PasswordVerificationToken)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("webpages_Membership");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ConfirmationToken).HasColumnName("ConfirmationToken");
            this.Property(t => t.IsConfirmed).HasColumnName("IsConfirmed");
            this.Property(t => t.LastPasswordFailureDate).HasColumnName("LastPasswordFailureDate");
            this.Property(t => t.PasswordFailuresSinceLastSuccess).HasColumnName("PasswordFailuresSinceLastSuccess");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.PasswordChangedDate).HasColumnName("PasswordChangedDate");
            this.Property(t => t.PasswordSalt).HasColumnName("PasswordSalt");
            this.Property(t => t.PasswordVerificationToken).HasColumnName("PasswordVerificationToken");
            this.Property(t => t.PasswordVerificationTokenExpirationDate).HasColumnName("PasswordVerificationTokenExpirationDate");
        }
    }
}
