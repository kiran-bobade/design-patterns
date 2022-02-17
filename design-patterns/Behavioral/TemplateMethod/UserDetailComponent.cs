namespace design_patterns.Behavioral.TemplateMethod
{
    public class UserDetailComponent : Component
    {
        public override string TemplatePath => "UserDetails.component.html";
        public override string StylePath => "UserDetails.component.css";

        public UserDetailComponent()
        {
            Console.WriteLine("\tUserDetailComponent -> Constructor");
        }

        protected override void OnChanges()
        {
            Console.WriteLine("\tUserDetailComponent -> OnChanges");
        }

        protected override void OnInit()
        {
            Console.WriteLine("\tUserDetailComponent -> OnInit");
        }
    }
}
