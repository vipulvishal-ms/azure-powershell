// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// A copy activity tabular translator.
    /// </summary>
    [Newtonsoft.Json.JsonObject("TabularTranslator")]
    public partial class TabularTranslator : CopyTranslator
    {
        /// <summary>
        /// Initializes a new instance of the TabularTranslator class.
        /// </summary>
        public TabularTranslator()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TabularTranslator class.
        /// </summary>

        /// <param name="additionalProperties">A copy activity translator.
        /// </param>

        /// <param name="columnMappings">Column mappings. Example: &#34;UserId: MyUserId, Group: MyGroup, Name: MyName&#34;
        /// Type: string (or Expression with resultType string). This property will be
        /// retired. Please use mappings property.
        /// </param>

        /// <param name="schemaMapping">The schema mapping to map between tabular data and hierarchical data.
        /// Example: {&#34;Column1&#34;: &#34;$.Column1&#34;, &#34;Column2&#34;: &#34;$.Column2.Property1&#34;,
        /// &#34;Column3&#34;: &#34;$.Column2.Property2&#34;}. Type: object (or Expression with
        /// resultType object). This property will be retired. Please use mappings
        /// property.
        /// </param>

        /// <param name="collectionReference">The JSON Path of the Nested Array that is going to do cross-apply. Type:
        /// object (or Expression with resultType object).
        /// </param>

        /// <param name="mapComplexValuesToString">Whether to map complex (array and object) values to simple strings in json
        /// format. Type: boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="mappings">Column mappings with logical types. Tabular-&gt;tabular example:
        /// [{&#34;source&#34;:{&#34;name&#34;:&#34;CustomerName&#34;,&#34;type&#34;:&#34;String&#34;},&#34;sink&#34;:{&#34;name&#34;:&#34;ClientName&#34;,&#34;type&#34;:&#34;String&#34;}},{&#34;source&#34;:{&#34;name&#34;:&#34;CustomerAddress&#34;,&#34;type&#34;:&#34;String&#34;},&#34;sink&#34;:{&#34;name&#34;:&#34;ClientAddress&#34;,&#34;type&#34;:&#34;String&#34;}}].
        /// Hierarchical-&gt;tabular example:
        /// [{&#34;source&#34;:{&#34;path&#34;:&#34;$.CustomerName&#34;,&#34;type&#34;:&#34;String&#34;},&#34;sink&#34;:{&#34;name&#34;:&#34;ClientName&#34;,&#34;type&#34;:&#34;String&#34;}},{&#34;source&#34;:{&#34;path&#34;:&#34;$.CustomerAddress&#34;,&#34;type&#34;:&#34;String&#34;},&#34;sink&#34;:{&#34;name&#34;:&#34;ClientAddress&#34;,&#34;type&#34;:&#34;String&#34;}}].
        /// Type: object (or Expression with resultType object).
        /// </param>

        /// <param name="typeConversion">Whether to enable the advanced type conversion feature in the Copy
        /// activity. Type: boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="typeConversionSettings">Type conversion settings
        /// </param>
        public TabularTranslator(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), object columnMappings = default(object), object schemaMapping = default(object), object collectionReference = default(object), object mapComplexValuesToString = default(object), object mappings = default(object), object typeConversion = default(object), TypeConversionSettings typeConversionSettings = default(TypeConversionSettings))

        : base(additionalProperties)
        {
            this.ColumnMappings = columnMappings;
            this.SchemaMapping = schemaMapping;
            this.CollectionReference = collectionReference;
            this.MapComplexValuesToString = mapComplexValuesToString;
            this.Mappings = mappings;
            this.TypeConversion = typeConversion;
            this.TypeConversionSettings = typeConversionSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets column mappings. Example: &#34;UserId: MyUserId, Group: MyGroup,
        /// Name: MyName&#34; Type: string (or Expression with resultType string). This
        /// property will be retired. Please use mappings property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "columnMappings")]
        public object ColumnMappings {get; set; }

        /// <summary>
        /// Gets or sets the schema mapping to map between tabular data and
        /// hierarchical data. Example: {&#34;Column1&#34;: &#34;$.Column1&#34;, &#34;Column2&#34;:
        /// &#34;$.Column2.Property1&#34;, &#34;Column3&#34;: &#34;$.Column2.Property2&#34;}. Type: object (or
        /// Expression with resultType object). This property will be retired. Please
        /// use mappings property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schemaMapping")]
        public object SchemaMapping {get; set; }

        /// <summary>
        /// Gets or sets the JSON Path of the Nested Array that is going to do
        /// cross-apply. Type: object (or Expression with resultType object).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "collectionReference")]
        public object CollectionReference {get; set; }

        /// <summary>
        /// Gets or sets whether to map complex (array and object) values to simple
        /// strings in json format. Type: boolean (or Expression with resultType
        /// boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mapComplexValuesToString")]
        public object MapComplexValuesToString {get; set; }

        /// <summary>
        /// Gets or sets column mappings with logical types. Tabular-&gt;tabular example:
        /// [{&#34;source&#34;:{&#34;name&#34;:&#34;CustomerName&#34;,&#34;type&#34;:&#34;String&#34;},&#34;sink&#34;:{&#34;name&#34;:&#34;ClientName&#34;,&#34;type&#34;:&#34;String&#34;}},{&#34;source&#34;:{&#34;name&#34;:&#34;CustomerAddress&#34;,&#34;type&#34;:&#34;String&#34;},&#34;sink&#34;:{&#34;name&#34;:&#34;ClientAddress&#34;,&#34;type&#34;:&#34;String&#34;}}].
        /// Hierarchical-&gt;tabular example:
        /// [{&#34;source&#34;:{&#34;path&#34;:&#34;$.CustomerName&#34;,&#34;type&#34;:&#34;String&#34;},&#34;sink&#34;:{&#34;name&#34;:&#34;ClientName&#34;,&#34;type&#34;:&#34;String&#34;}},{&#34;source&#34;:{&#34;path&#34;:&#34;$.CustomerAddress&#34;,&#34;type&#34;:&#34;String&#34;},&#34;sink&#34;:{&#34;name&#34;:&#34;ClientAddress&#34;,&#34;type&#34;:&#34;String&#34;}}].
        /// Type: object (or Expression with resultType object).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mappings")]
        public object Mappings {get; set; }

        /// <summary>
        /// Gets or sets whether to enable the advanced type conversion feature in the
        /// Copy activity. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeConversion")]
        public object TypeConversion {get; set; }

        /// <summary>
        /// Gets or sets type conversion settings
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeConversionSettings")]
        public TypeConversionSettings TypeConversionSettings {get; set; }
    }
}