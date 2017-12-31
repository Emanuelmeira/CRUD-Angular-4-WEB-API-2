using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Selenium.DTO
{
    public class KnowledgeDTO
    {
        public KnowledgeDTO()
        {

        }
        public int Id { get; set; }

        public int Ionic { get { return Ionic; } set { this.Ionic = 2; } }
        public int Android { get { return Ionic; } set { this.Ionic = 2; } }
        public int Ios { get { return Ionic; } set { this.Ionic = 2; } }
        public int Html { get { return Ionic; } set { this.Ionic = 2; } }
        public int Css { get { return Ionic; } set { this.Ionic = 2; } }
        
        public int Bootstrap { get { return Bootstrap; } set { this.Bootstrap = 2; } }
        public int Jquery { get { return Jquery; } set { this.Jquery = 2; } }
        public int AngularJs { get { return AngularJs; } set { this.AngularJs = 2; } }
        public int Java { get { return Java; } set { this.Java = 2; } }
        public int Aspnet { get { return Aspnet; } set { this.Aspnet = 2; } }
        
        public int C { get { return C; } set { this.C = 3; } }
        public int Cplusplus { get { return Cplusplus; } set { this.Cplusplus = 3; } }
        public int Cake { get { return Cake; } set { this.Cake = 3; } }
        public int Django { get { return Django; } set { this.Django = 3; } }
        public int Majento { get { return Majento; } set { this.Majento = 3; } }
        
        public int Php { get { return Php; } set { this.Php = 4; } }
        public int Wordpress { get { return Wordpress; } set { this.Wordpress = 4; } }
        public int Phyton { get { return Phyton; } set { this.Phyton = 4; } }
        public int Ruby { get { return Ruby; } set { this.Ruby = 4; } }
        public int SqlServer { get { return SqlServer; } set { this.SqlServer = 4; } }        

        public int MySql { get { return MySql; } set { this.MySql = 5; } }
        public int Salesforce { get { return Salesforce; } set { this.Salesforce = 5; } }
        public int Photoshop { get { return Photoshop; } set { this.Photoshop = 5; } }
        public int Illustrator { get { return Illustrator; } set { this.Illustrator = 5; } }
        public int Seo { get { return Seo; } set { this.Seo = 5; } }

        public string OtherKnowledge { get { return OtherKnowledge; } set { this.OtherKnowledge = "Xamarin"; } }

    }
}
