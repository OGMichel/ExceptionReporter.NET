﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExceptionReporter.Shared.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExceptionReporter.Shared.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à The email is ready to be sent.
        ///Information about the error is included below. Please feel free to add any relevant information or attach additional files.
        ///{{#if ScreenshotTaken}}
        ///A screenshot, taken at the time of the exception, is attached.
        ///You may delete the attachment before sending if you prefer.
        ///{{/if}}
        ///.
        /// </summary>
        public static string EmailIntroTemplate_text {
            get {
                return ResourceManager.GetString("EmailIntroTemplate.text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à &lt;!DOCTYPE html&gt;
        ///&lt;html lang=&quot;{{App.Language}}&quot;&gt;
        ///&lt;head&gt;
        ///	&lt;meta charset=&quot;UTF-8&quot;&gt;
        ///	&lt;title&gt; {{App.Title}} &lt;/title&gt;
        ///&lt;/head&gt;
        ///
        ///&lt;body&gt;
        ///	&lt;div id=&quot;exception-report-{{Error.ID}}&quot; class=&quot;exception-report&quot;&gt;
        ///		
        ///		&lt;div class=&quot;header&quot;&gt;
        ///			&lt;h1&gt; {{App.Title}} &lt;/h1&gt;				 
        ///		&lt;/div&gt;
        ///	
        ///		&lt;div class=&quot;content&quot;&gt;		
        ///			&lt;table class=&quot;fields&quot;&gt;
        ///				&lt;tr class=&quot;app-name&quot;&gt;
        ///					&lt;td&gt; Application: &lt;/td&gt;
        ///					&lt;td&gt; {{App.Name}} &lt;/td&gt;
        ///				&lt;/tr&gt;
        ///				&lt;tr class=&quot;app-version&quot;&gt;
        ///					&lt;td&gt; Version: &lt;/td&gt;
        ///					&lt;td&gt; {{App.Version}} &lt; [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        public static string ReportTemplate_html {
            get {
                return ResourceManager.GetString("ReportTemplate.html", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à # {{App.Title}}
        ///
        ///**Application**: {{App.Name}}  
        ///**Version**:     {{App.Version}}  
        ///**Region**:      {{App.Region}}  
        ///{{#if App.User}}
        ///**User**:        {{App.User}}  
        ///{{/if}}    
        ///**Date**: {{Error.Date}}  
        ///**Time**: {{Error.Time}}  
        ///{{#if Error.Explanation}}
        ///**User Explanation**: {{Error.Explanation}}  
        ///{{/if}}
        ///
        ///**Error Message**: {{Error.Message}}
        /// 
        ///## Stack Traces
        ///```shell
        ///{{Error.FullStackTrace}} 
        ///```
        /// 
        ///## Assembly References
        ///{{#App.AssemblyRefs}}
        /// - {{Name}}, Version={{Version}}   [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        public static string ReportTemplate_markdown {
            get {
                return ResourceManager.GetString("ReportTemplate.markdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à ========================================
        ///
        ///[General Info]
        ///Application: {{App.Name}}
        ///Version:     {{App.Version}}
        ///Region:      {{App.Region}}
        ///{{#if App.User}}
        ///User:        {{App.User}}
        ///{{/if}}
        ///Date: {{Error.Date}}
        ///Time: {{Error.Time}}
        ///{{#if Error.Explanation}}
        ///User Explanation: {{Error.Explanation}}
        ///{{/if}}
        ///
        ///Error Message: {{Error.Message}}
        /// 
        ///[Stack Traces] 
        ///{{Error.FullStackTrace}} 
        /// 
        ///[Assembly References] 
        ///{{#App.AssemblyRefs}}
        ///  {{Name}}, Version={{Version}}
        ///{{/App.AssemblyRefs}}
        ///
        /// [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        public static string ReportTemplate_text {
            get {
                return ResourceManager.GetString("ReportTemplate.text", resourceCulture);
            }
        }
    }
}
