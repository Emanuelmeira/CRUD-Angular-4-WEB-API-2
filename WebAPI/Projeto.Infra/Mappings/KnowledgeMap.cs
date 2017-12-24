using Easy.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Mappings
{
    class KnowledgeMap : EntityTypeConfiguration<Knowledge>
    {
        public KnowledgeMap()
        {
            ToTable("KNOWLED");

            HasKey(x => x.Id);
            
            Property(x => x.Ionic).IsRequired();
            Property(x => x.Android).IsRequired();
            Property(x => x.Ios).IsRequired();
            Property(x => x.Html);
            Property(x => x.Css);
            Property(x => x.Bootstrap).IsRequired();
            Property(x => x.Jquery).IsRequired();
            Property(x => x.AngularJs).IsRequired();
            Property(x => x.Java);
            Property(x => x.Aspnet).IsRequired();
            Property(x => x.C);
            Property(x => x.Cplusplus);
            Property(x => x.Cake);
            Property(x => x.Django);
            Property(x => x.Majento);
            Property(x => x.Php).IsRequired();
            Property(x => x.Wordpress).IsRequired();
            Property(x => x.Phyton);
            Property(x => x.Ruby);
            Property(x => x.SqlServer);
            Property(x => x.MySql);
            Property(x => x.Salesforce);
            Property(x => x.Photoshop);
            Property(x => x.Illustrator);
            Property(x => x.Seo);

            Property(x => x.OtherKnowledge).HasMaxLength(60).IsRequired();            

        }
    }
}
