using System.Reflection;
using Kashanshop.Data.sqlserver.Config.Category;
using Kashanshop.Data.sqlserver.Config.Factor;
using Kashanshop.Data.sqlserver.Config.FeedBack;
using Kashanshop.Data.sqlserver.Config.News;
using Kashanshop.Data.sqlserver.Config.Product;
using Kashanshop.Data.sqlserver.Config.User;
using Kashanshop.Domain;
using Kashanshop.Domain.Factor;
using Kashanshop.Domain.Feedback;
using Kashanshop.Domain.News;
using Kashanshop.Domain.User;
using Microsoft.EntityFrameworkCore;


namespace Kashanshop.Data.sqlserver;

public class ApplicationDbContext : DbContext
{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OtpCode> OtpCodes { get; set; }
        public DbSet<ReceiverAddress> ReceiverAddresses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<FactorItem> FactorItems { get; set; }
        //public DbSet<News> NewsEnumerable { get; set; }
        public DbSet<NewsCategory> CategoryNewsEnumerable { get; set; }
        public DbSet<CommentReply> CommentReplies { get; set; }
        //public DbSet<NewsPopularity> NewsPops { get; set; }
        //public DbSet<NewsView> NewsViews { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductPopularity> ProductPopularities { get; set; }
        public DbSet<ProductQuestion> ProductQuestions { get; set; }
        public DbSet<ProductView> ProductViews { get; set; }
        public DbSet<QuestionReply> QuestionReplies { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldValue> FieldValues { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductField> ProductFields { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ProductCategoryConfig)));
                
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(FactorConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(FactorItemConfig)));

                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(CommentReplyConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(NewsPopularityConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(NewsViewConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ProductCommentConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ProductPopularityConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(QuestionReplyConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ProductViewConfig)));
                
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(NewsConfig)));
                
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ProductPriceConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ProductFieldConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ProductConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ProductFieldConfig)));
                //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof()));
                //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof()));
                
                
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(MessageConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(OtpCodeConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ReceiverAddressConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(UserRoleConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(UserConfig)));
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(RoleConfig)));
                

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
                var entries = ChangeTracker
                        .Entries()
                        .Where(x => x.Entity is BaseEntity)
                        .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified)
                        .ToList();
                foreach (var entry in entries)
                {
                        ((BaseEntity) entry.Entity).CreationDate = DateTime.Now;
                }

                return base.SaveChangesAsync(cancellationToken);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
                configurationBuilder.Properties<string>().HaveMaxLength(50);
                base.ConfigureConventions(configurationBuilder);
        }
        
}












