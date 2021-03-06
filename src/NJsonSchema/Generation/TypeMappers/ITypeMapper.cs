using System;

namespace NJsonSchema.Generation.TypeMappers
{
    /// <summary>Maps .NET type to a generated JSON Schema.</summary>
    public interface ITypeMapper
    {
        /// <summary>Gets the mapped type.</summary>
        Type MappedType { get; }

        /// <summary>Gets a value indicating whether to use a JSON Schema reference for the type.</summary>
        bool UseReference { get; }

        /// <summary>Gets the schema for the mapped type.</summary>
        /// <typeparam name="TSchemaType">The type of the schema type.</typeparam>
        /// <param name="schemaGenerator">The schema generator.</param>
        /// <param name="schemaResolver">The schema resolver.</param>
        /// <returns>The schema.</returns>
        TSchemaType GetSchema<TSchemaType>(JsonSchemaGenerator schemaGenerator, ISchemaResolver schemaResolver)
            where TSchemaType : JsonSchema4, new();
    }
}