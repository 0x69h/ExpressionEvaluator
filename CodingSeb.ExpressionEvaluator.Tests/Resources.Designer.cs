﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodingSeb.ExpressionEvaluator.Tests {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodingSeb.ExpressionEvaluator.Tests.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0001 */
        ///x = 0;
        ///result = &quot;&quot;;
        ///
        ///while(x &lt; 5)
        ///{
        ///	result += $&quot;{x},&quot;;
        ///	x++;
        ///}
        ///
        ///result.Remove(result.Length - 1);.
        /// </summary>
        internal static string Script0001 {
            get {
                return ResourceManager.GetString("Script0001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0002 */
        ///result = &quot;&quot;;
        ///
        ///for(x = 0; x &lt; 5;x++)
        ///{
        ///	result += $&quot;{x},&quot;;
        ///}
        ///
        ///result.Remove(result.Length - 1);.
        /// </summary>
        internal static string Script0002 {
            get {
                return ResourceManager.GetString("Script0002", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0003 */
        ///result = &quot;&quot;;
        ///
        ///for(x = 0; x &lt; 5;x++)
        ///	result += $&quot;{x},&quot;;
        ///
        ///result.Remove(result.Length - 1);.
        /// </summary>
        internal static string Script0003 {
            get {
                return ResourceManager.GetString("Script0003", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0004 */
        ///x = [valx];
        ///y = [valy];
        ///result = 0;
        ///
        ///if(y != 0)
        ///{
        ///	result = 1;
        ///}
        ///else if(x == 0)
        ///{
        ///	result = 2;
        ///}
        ///else if(x &lt; 0)
        ///{
        ///	result = 3;
        ///}
        ///else
        ///{
        ///	result = 4;
        ///}
        ///
        ///result;.
        /// </summary>
        internal static string Script0004 {
            get {
                return ResourceManager.GetString("Script0004", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0005 */
        ///x = [valx];
        ///y = [valy];
        ///result = 0;
        ///
        ///if(y != 0)
        ///	result = 1;
        ///else if(x == 0)
        ///	result = 2;
        ///else if(x &lt; 0)
        ///	result = 3;
        ///else
        ///	result = 4;
        ///
        ///result;.
        /// </summary>
        internal static string Script0005 {
            get {
                return ResourceManager.GetString("Script0005", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0006 */
        ///List(1,2,3,4)
        ///    .Find((element) =&gt; 
        ///    {
        ///        x = 2 + 2;
        ///        element == 3;
        ///    });.
        /// </summary>
        internal static string Script0006 {
            get {
                return ResourceManager.GetString("Script0006", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0007 */
        ///x = 4;
        ///y = 0;
        ///
        ///if(x == 4)
        ///	y = List(1,2,3,4)
        ///		.Find((element) =&gt; 
        ///		{
        ///			x = 2 + 2;
        ///			element == 3;
        ///		}) + 10;
        ///
        ///.
        /// </summary>
        internal static string Script0007 {
            get {
                return ResourceManager.GetString("Script0007", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0008 */
        ///x = [valx];
        ///
        ///if(x == 0)
        ///	return 2;
        ///	
        ///x;.
        /// </summary>
        internal static string Script0008 {
            get {
                return ResourceManager.GetString("Script0008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0009 */
        ///x = &quot;&quot;;
        ///
        ///for(i = 0; i &lt; 10; i++)
        ///{
        ///	if(i == 3)
        ///		continue;
        ///		
        ///	x += $&quot;{i},&quot;;
        ///	
        ///	if(i == 6)
        ///		break;
        ///}
        ///	
        ///x;.
        /// </summary>
        internal static string Script0009 {
            get {
                return ResourceManager.GetString("Script0009", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0010 */
        ///x = &quot;&quot;;
        ///i = -1;
        ///
        ///while(i &lt; 10)
        ///{
        ///	i++;
        ///
        ///	if(i == 3)
        ///		continue;
        ///		
        ///	x += $&quot;{i},&quot;;
        ///	
        ///	if(i == 6)
        ///		break;
        ///}
        ///	
        ///x;.
        /// </summary>
        internal static string Script0010 {
            get {
                return ResourceManager.GetString("Script0010", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0011 */
        ///list = List(5,5,5,5,5,5,5,5,5,5,5);
        ///
        ///list[0] = 8;
        ///list[1] += 6;
        ///list[2] -= 2;
        ///list[3] *= 3;
        ///list[4] /= 2;
        ///list[5] %= 2;
        ///list[6] ^= 3;
        ///list[7] &amp;= 3;
        ///list[8] |= 3;
        ///list[9] &lt;&lt;= 2;
        ///list[10] &gt;&gt;=2;
        ///
        ///return list.Json;.
        /// </summary>
        internal static string Script0011 {
            get {
                return ResourceManager.GetString("Script0011", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0012 */
        ///list = List(5,5,5,5,5,5);
        ///
        ///list[0]++;
        ///list[1]--;
        ///list[2] += list[3]++; 
        ///list[4] += list[5]--;
        ///
        ///return list.Json;.
        /// </summary>
        internal static string Script0012 {
            get {
                return ResourceManager.GetString("Script0012", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0013 */
        ///x = 0;
        ///result = &quot;&quot;;
        ///
        ///do
        ///{
        ///	result += $&quot;{x},&quot;;
        ///	x++;
        ///}
        ///while(x &lt; 5);
        ///
        ///result.Remove(result.Length - 1);.
        /// </summary>
        internal static string Script0013 {
            get {
                return ResourceManager.GetString("Script0013", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0014 */
        ///x = 0;
        ///result = &quot;&quot;;
        ///
        ///do
        ///{
        ///	result += $&quot;{x},&quot;;
        ///	x++;
        ///}
        ///while(false);
        ///
        ///result.Remove(result.Length - 1);.
        /// </summary>
        internal static string Script0014 {
            get {
                return ResourceManager.GetString("Script0014", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0015 */
        ///x = 0;
        ///result = &quot;&quot;;
        ///
        ///while(false)
        ///{
        ///	result += $&quot;{x},&quot;;
        ///	x++;
        ///}
        ///
        ///
        ///result;.
        /// </summary>
        internal static string Script0015 {
            get {
                return ResourceManager.GetString("Script0015", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0016 */
        ///Add = (x, y) =&gt; x + y;
        ///
        ///return Add(3, 4);.
        /// </summary>
        internal static string Script0016 {
            get {
                return ResourceManager.GetString("Script0016", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0017 */
        ///
        ///FirstFunc = x =&gt; 
        ///{
        ///	y = 3;
        ///	return x + y; 
        ///};
        ///
        ///SecondFunc = (x, y) =&gt; FirstFunc(x) - y;
        ///
        ///return SecondFunc(5, 2);.
        /// </summary>
        internal static string Script0017 {
            get {
                return ResourceManager.GetString("Script0017", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0018 */
        ///
        ///result = string.Empty;
        ///elements = List(&quot;This&quot;, &quot;is&quot;, &quot;a&quot;, &quot;splitted&quot;, &quot;text&quot;);
        ///
        ///foreach(element in elements)
        ///{
        ///	result += element;
        ///	result += &quot; &quot;;
        ///}
        ///
        ///result.Remove(result.Length - 1);.
        /// </summary>
        internal static string Script0018 {
            get {
                return ResourceManager.GetString("Script0018", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0019 */
        ///myVar = new ExpandoObject();
        ///
        ///myVar.X = 23.5;
        ///myVar.Y = 34.8;
        ///
        ///return myVar.X + myVar.Y;.
        /// </summary>
        internal static string Script0019 {
            get {
                return ResourceManager.GetString("Script0019", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0020 */
        ///myVar = new ExpandoObject();
        ///
        ///myVar[&quot;X&quot;] = 23.5;
        ///myVar[&quot;Y&quot;] = 34.8;
        ///
        ///return myVar.X + myVar.Y;.
        /// </summary>
        internal static string Script0020 {
            get {
                return ResourceManager.GetString("Script0020", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0021 */
        ///myVar = new ExpandoObject();
        ///
        ///myVar[&quot;X&quot;] = 23.5;
        ///myVar[&quot;Y&quot;] = 34.8;
        ///
        ///return myVar[&quot;X&quot;] + myVar[&quot;Y&quot;];.
        /// </summary>
        internal static string Script0021 {
            get {
                return ResourceManager.GetString("Script0021", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0022 */
        ///myVar = new ExpandoObject();
        ///
        ///myVar.X = 23.5;
        ///myVar.Y = 34.8;
        ///
        ///return myVar[&quot;X&quot;] + myVar[&quot;Y&quot;];.
        /// </summary>
        internal static string Script0022 {
            get {
                return ResourceManager.GetString("Script0022", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0023 */
        ///myVar = new ExpandoObject();
        ///
        ///myVar.X = 2;
        ///myVar.X++;
        ///myVar[&quot;Y&quot;] = 1;
        ///myVar[&quot;Y&quot;]++;
        ///
        ///return myVar[&quot;X&quot;] + myVar.Y;.
        /// </summary>
        internal static string Script0023 {
            get {
                return ResourceManager.GetString("Script0023", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0024 */
        ///obj = new ExpandoObject();
        ///
        ///obj.Add = (x, y) =&gt; 
        ///{
        ///	text = &quot;The result is : &quot;;
        ///	return text + (x+y).ToString();
        ///};
        ///
        ///return obj.Add(3, 4);.
        /// </summary>
        internal static string Script0024 {
            get {
                return ResourceManager.GetString("Script0024", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0025 */
        ///
        ///throw new Exception(&quot;Exception for test&quot;);.
        /// </summary>
        internal static string Script0025 {
            get {
                return ResourceManager.GetString("Script0025", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0026 */
        ///
        ///varçÿ = &quot;A value in diactitic varçÿ&quot;;
        ///
        ///áàâãåǎăāąæéèêëěēĕėęěìíîïīĭįĳóôõöōŏőøðœùúûüǔũūŭůűųýþÿŷıćĉċčçďđĝğġģĥħĵķĺļľŀłńņňŋñŕŗřśŝşšţťŧŵźżžÁÀÂÃÅǍĂĀĄÆÉÈÊËĚĒĔĖĘĚÌÍÎÏĪĬĮĲÓÔÕÖŌŎŐØÐŒÙÚÛÜǓŨŪŬŮŰŲÝÞŸŶIĆĈĊČÇĎĐĜĞĠĢĤĦĴĶĹĻĽĿŁŃŅŇŊÑŔŖŘŚŜŞŠŢŤŦŴŹŻŽß = &quot;very complex var&quot;;
        ///
        ///return $&quot;{varçÿ} &amp;&amp; {áàâãåǎăāąæéèêëěēĕėęěìíîïīĭįĳóôõöōŏőøðœùúûüǔũūŭůűųýþÿŷıćĉċčçďđĝğġģĥħĵķĺļľŀłńņňŋñŕŗřśŝşšţťŧŵźżžÁÀÂÃÅǍĂĀĄÆÉÈÊËĚĒĔĖĘĚÌÍÎÏĪĬĮĲÓÔÕÖŌŎŐØÐŒÙÚÛÜǓŨŪŬŮŰŲÝÞŸŶIĆĈĊČÇĎĐĜĞĠĢĤĦĴĶĹĻĽĿŁŃŅŇŊÑŔŖŘŚŜŞŠŢŤŦŴŹŻŽß}&quot;;.
        /// </summary>
        internal static string Script0026 {
            get {
                return ResourceManager.GetString("Script0026", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0027 */
        ///
        ///test = new áàâãåǎăāąæéèêëěēĕėęěìíîïīĭįĳóôõöōŏőøðœùúûüǔũūŭůűųýþÿŷıćĉċčçďđĝğġģĥħĵķĺļľŀłńņňŋñŕŗřśŝşšţťŧŵźżžÁÀÂÃÅǍĂĀĄÆÉÈÊËĚĒĔĖĘĚÌÍÎÏĪĬĮĲÓÔÕÖŌŎŐØÐŒÙÚÛÜǓŨŪŬŮŰŲÝÞŸŶIĆĈĊČÇĎĐĜĞĠĢĤĦĴĶĹĻĽĿŁŃŅŇŊÑŔŖŘŚŜŞŠŢŤŦŴŹŻŽß();
        ///
        ///return test.Přōþěŕŧÿ;.
        /// </summary>
        internal static string Script0027 {
            get {
                return ResourceManager.GetString("Script0027", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0028 */
        ///
        ///x = 5;
        ///y = 0;
        ///
        ///c = false;
        ///f = false;
        ///
        ///try
        ///{
        ///	x / y;
        ///}
        ///catch(exception)
        ///{
        ///	c = true;
        ///}
        ///finally
        ///{
        ///	f = true;
        ///}
        ///
        ///return $&quot;catch : {c}, finally : {f}&quot;;.
        /// </summary>
        internal static string Script0028 {
            get {
                return ResourceManager.GetString("Script0028", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0029 */
        ///
        ///x = 5;
        ///y = 0;
        ///
        ///c = false;
        ///f = false;
        ///
        ///try
        ///{
        ///	x / y;
        ///}
        ///finally
        ///{
        ///	ClassForTest1.StaticIntProperty = 20;
        ///	f = true;
        ///}
        ///
        ///return $&quot;catch : {c}, finally : {f}&quot;;.
        /// </summary>
        internal static string Script0029 {
            get {
                return ResourceManager.GetString("Script0029", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0030 */
        ///
        ///x = 5;
        ///y = 0;
        ///
        ///c = false;
        ///f = false;
        ///
        ///try
        ///{
        ///	x / y;
        ///}
        ///catch(exception)
        ///{
        ///	c = true;
        ///}
        ///
        ///return $&quot;catch : {c}, finally : {f}&quot;;.
        /// </summary>
        internal static string Script0030 {
            get {
                return ResourceManager.GetString("Script0030", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0031 */
        ///
        ///x = 5;
        ///y = 0;
        ///
        ///c = 0;
        ///f = false;
        ///
        ///try
        ///{
        ///	x / y;
        ///}
        ///catch(DivideByZeroExceptionexception exception)
        ///{
        ///	c = 1;
        ///}
        ///catch(Exception exception)
        ///{
        ///	c = 2;
        ///}
        ///finally
        ///{
        ///	f = true;
        ///}
        ///
        ///return $&quot;catch : {c}, finally : {f}&quot;;.
        /// </summary>
        internal static string Script0031 {
            get {
                return ResourceManager.GetString("Script0031", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à /* Script0032 */
        ///
        ///c = 0;
        ///f = false;
        ///
        ///try
        ///{
        ///	throw new Exception(&quot;My exception&quot;);
        ///}
        ///catch(DivideByZeroExceptionexception exception)
        ///{
        ///	c = 1;
        ///}
        ///catch(Exception exception)
        ///{
        ///	c = 2;
        ///}
        ///finally
        ///{
        ///	f = true;
        ///}
        ///
        ///return $&quot;catch : {c}, finally : {f}&quot;;.
        /// </summary>
        internal static string Script0032 {
            get {
                return ResourceManager.GetString("Script0032", resourceCulture);
            }
        }
    }
}
