using BarberScheduler.Infrastructure.PostgreSQL.MartenDB.Registries;
using LamarCodeGeneration;
using Marten;
using Marten.Services.Json;
using Microsoft.Extensions.Configuration;
using Weasel.Core;

namespace BarberScheduler.Infrastructure.PostgreSQL.MartenDB.Configuration;

internal sealed class CustomStoreOptions : StoreOptions
{
    public CustomStoreOptions(IConfiguration configuration)
    {
        DatabaseSchemaName = "Marten_DocumentDB";
        AutoCreateSchemaObjects = AutoCreate.CreateOrUpdate;
        GeneratedCodeMode = TypeLoadMode.Auto;
        Connection(configuration.GetConnectionString("Marten"));
        UseDefaultSerialization(
            enumStorage: EnumStorage.AsString,
            casing: default,
            collectionStorage: default,
            nonPublicMembersStorage: NonPublicMembersStorage.All,
            serializerType: SerializerType.SystemTextJson);
        //Serializer(new JsonNetSerializer
        //{
        //    EnumStorage = EnumStorage.AsString,
        //    NonPublicMembersStorage = NonPublicMembersStorage.All,
        //});

        Policies.ForAllDocuments(c =>
        {
            c.DeleteStyle = Marten.Schema.DeleteStyle.Remove;
        });

        Schema.Include<UserRegistry>();
    }
}