using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod
{
    public abstract class Component
    {
        public abstract string TemplatePath { get; }
        public abstract string StylePath { get; }
        public void Render()
        {
            ParseTemplate();
            RegisterChangeDetector();
            Console.WriteLine("\tExecuting life cycle hook: OnChanges");
            OnChanges();
            Console.WriteLine("\tExecuting life cycle hook: OnInit");
            OnInit();
        }

        private void RegisterChangeDetector()
        {
            Console.WriteLine("\tInitializing Change Detector");
        }

        private void ParseTemplate()
        {
            LoadStyles();
            Console.WriteLine($"\tParsing Template: {TemplatePath}");
        }

        private void LoadStyles()
        {
            Console.WriteLine($"\tLoading Stylesheet: {StylePath}");
        }

        protected virtual void OnChanges() { }
        protected virtual void OnInit() { }
    }
}
