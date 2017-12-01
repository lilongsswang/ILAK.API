﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 15.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ILAK.API.CodeGenerate.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class Services : ServicesBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("  \r\nusing System;\r\nusing System.IO;\r\nusing System.ServiceModel.Web;\r\nnamespace Te" +
                    "mpRestHostService\r\n{\r\n\t");
            
            #line 12 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
 foreach (var k in IntfOptions.Interfaces) {
            
            #line default
            #line hidden
            this.Write("    public class Service");
            
            #line 13 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(k.IntfCode));
            
            #line default
            #line hidden
            this.Write(" : Interface");
            
            #line 13 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(k.IntfCode));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n\t");
            
            #line 15 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
 
		foreach (var item in IntfOptions.Interfaces) { 
			foreach(var mitem in item.Methods) {
            
            #line default
            #line hidden
            this.Write("        public Stream M");
            
            #line 18 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mitem.MCode));
            
            #line default
            #line hidden
            this.Write("(Req");
            
            #line 18 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mitem.MAgOption.AgCode));
            
            #line default
            #line hidden
            this.Write(@" input)
		{
			WebOperationContext.Current.OutgoingResponse.ContentType = Messages.RESTFUL_OUTPUT_CONTENTTYPE;
			RetBase<dynamic> ret = new RetBase<dynamic>();
			if (input == null)
            {
                ret.code = ""-1"";
                ret.msg = Messages.PARAM_NOT_ALLOW_EMPTY;
                return ret.ToStream();
            }
			Controller");
            
            #line 28 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.IntfCode));
            
            #line default
            #line hidden
            this.Write(" control = new Controller");
            
            #line 28 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.IntfCode));
            
            #line default
            #line hidden
            this.Write("();\r\n            try\r\n            {\r\n\t\t\t\tret = control.Do");
            
            #line 31 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mitem.MCode));
            
            #line default
            #line hidden
            this.Write(@"(input);
                ret.code = ""1"";
                ret.msg = ""成功"";
            }
            catch (BusinessException bex)
            {
                ret.code = ""-1"";
                ret.msg = bex.Message;
                return ret.ToStream();
            }
            catch (Exception unkown)
            {
                ret.code = ""-2"";
                ret.msg = unkown.Message;
                return ret.ToStream();
            }
            return ret.ToStream();
		}
		");
            
            #line 49 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"

			}
		} 
            
            #line default
            #line hidden
            this.Write("    }\r\n\t");
            
            #line 53 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"
 } 
            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "E:\data\ILAK\ILAK.API\ILAK.API\CodeGenerate\Templates\Services.tt"

private global::ILAK.API.ListOfIntfGenOption _IntfOptionsField;

/// <summary>
/// Access the IntfOptions parameter of the template.
/// </summary>
private global::ILAK.API.ListOfIntfGenOption IntfOptions
{
    get
    {
        return this._IntfOptionsField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool IntfOptionsValueAcquired = false;
if (this.Session.ContainsKey("IntfOptions"))
{
    this._IntfOptionsField = ((global::ILAK.API.ListOfIntfGenOption)(this.Session["IntfOptions"]));
    IntfOptionsValueAcquired = true;
}
if ((IntfOptionsValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("IntfOptions");
    if ((data != null))
    {
        this._IntfOptionsField = ((global::ILAK.API.ListOfIntfGenOption)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class ServicesBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
