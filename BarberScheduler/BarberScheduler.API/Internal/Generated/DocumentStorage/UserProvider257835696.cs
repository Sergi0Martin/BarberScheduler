// <auto-generated/>
#pragma warning disable
using BarberScheduler.Domain.Aggregates.Users;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertUserOperation257835696
    public class UpsertUserOperation257835696 : Marten.Internal.Operations.StorageOperation<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>
    {
        private readonly BarberScheduler.Domain.Aggregates.Users.User _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertUserOperation257835696(BarberScheduler.Domain.Aggregates.Users.User document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select marten_documentdb.mt_upsert_users(?, ?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;

            if (document.UserName != null)
            {
                parameters[0].Value = document.UserName;
            }

            else
            {
                parameters[0].Value = System.DBNull.Value;
            }

            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[1].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[2].Value = _document.GetType().FullName;
            parameters[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[3].Value = document.Id;
            setVersionParameter(parameters[4]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertUserOperation257835696
    
    
    // START: InsertUserOperation257835696
    public class InsertUserOperation257835696 : Marten.Internal.Operations.StorageOperation<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>
    {
        private readonly BarberScheduler.Domain.Aggregates.Users.User _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertUserOperation257835696(BarberScheduler.Domain.Aggregates.Users.User document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select marten_documentdb.mt_insert_users(?, ?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;

            if (document.UserName != null)
            {
                parameters[0].Value = document.UserName;
            }

            else
            {
                parameters[0].Value = System.DBNull.Value;
            }

            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[1].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[2].Value = _document.GetType().FullName;
            parameters[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[3].Value = document.Id;
            setVersionParameter(parameters[4]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertUserOperation257835696
    
    
    // START: UpdateUserOperation257835696
    public class UpdateUserOperation257835696 : Marten.Internal.Operations.StorageOperation<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>
    {
        private readonly BarberScheduler.Domain.Aggregates.Users.User _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateUserOperation257835696(BarberScheduler.Domain.Aggregates.Users.User document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select marten_documentdb.mt_update_users(?, ?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;

            if (document.UserName != null)
            {
                parameters[0].Value = document.UserName;
            }

            else
            {
                parameters[0].Value = System.DBNull.Value;
            }

            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[1].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[2].Value = _document.GetType().FullName;
            parameters[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[3].Value = document.Id;
            setVersionParameter(parameters[4]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateUserOperation257835696
    
    
    // START: QueryOnlyUserSelector257835696
    public class QueryOnlyUserSelector257835696 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<BarberScheduler.Domain.Aggregates.Users.User>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyUserSelector257835696(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public BarberScheduler.Domain.Aggregates.Users.User Resolve(System.Data.Common.DbDataReader reader)
        {

            BarberScheduler.Domain.Aggregates.Users.User document;
            document = _serializer.FromJson<BarberScheduler.Domain.Aggregates.Users.User>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<BarberScheduler.Domain.Aggregates.Users.User> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            BarberScheduler.Domain.Aggregates.Users.User document;
            document = await _serializer.FromJsonAsync<BarberScheduler.Domain.Aggregates.Users.User>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyUserSelector257835696
    
    
    // START: LightweightUserSelector257835696
    public class LightweightUserSelector257835696 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>, Marten.Linq.Selectors.ISelector<BarberScheduler.Domain.Aggregates.Users.User>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightUserSelector257835696(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public BarberScheduler.Domain.Aggregates.Users.User Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            BarberScheduler.Domain.Aggregates.Users.User document;
            document = _serializer.FromJson<BarberScheduler.Domain.Aggregates.Users.User>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<BarberScheduler.Domain.Aggregates.Users.User> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            BarberScheduler.Domain.Aggregates.Users.User document;
            document = await _serializer.FromJsonAsync<BarberScheduler.Domain.Aggregates.Users.User>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightUserSelector257835696
    
    
    // START: IdentityMapUserSelector257835696
    public class IdentityMapUserSelector257835696 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>, Marten.Linq.Selectors.ISelector<BarberScheduler.Domain.Aggregates.Users.User>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapUserSelector257835696(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public BarberScheduler.Domain.Aggregates.Users.User Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            BarberScheduler.Domain.Aggregates.Users.User document;
            document = _serializer.FromJson<BarberScheduler.Domain.Aggregates.Users.User>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<BarberScheduler.Domain.Aggregates.Users.User> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            BarberScheduler.Domain.Aggregates.Users.User document;
            document = await _serializer.FromJsonAsync<BarberScheduler.Domain.Aggregates.Users.User>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapUserSelector257835696
    
    
    // START: DirtyTrackingUserSelector257835696
    public class DirtyTrackingUserSelector257835696 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>, Marten.Linq.Selectors.ISelector<BarberScheduler.Domain.Aggregates.Users.User>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingUserSelector257835696(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public BarberScheduler.Domain.Aggregates.Users.User Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            BarberScheduler.Domain.Aggregates.Users.User document;
            document = _serializer.FromJson<BarberScheduler.Domain.Aggregates.Users.User>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<BarberScheduler.Domain.Aggregates.Users.User> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            BarberScheduler.Domain.Aggregates.Users.User document;
            document = await _serializer.FromJsonAsync<BarberScheduler.Domain.Aggregates.Users.User>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingUserSelector257835696
    
    
    // START: QueryOnlyUserDocumentStorage257835696
    public class QueryOnlyUserDocumentStorage257835696 : Marten.Internal.Storage.QueryOnlyDocumentStorage<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyUserDocumentStorage257835696(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(BarberScheduler.Domain.Aggregates.Users.User document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(BarberScheduler.Domain.Aggregates.Users.User document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyUserSelector257835696(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyUserDocumentStorage257835696
    
    
    // START: LightweightUserDocumentStorage257835696
    public class LightweightUserDocumentStorage257835696 : Marten.Internal.Storage.LightweightDocumentStorage<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightUserDocumentStorage257835696(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(BarberScheduler.Domain.Aggregates.Users.User document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(BarberScheduler.Domain.Aggregates.Users.User document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightUserSelector257835696(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightUserDocumentStorage257835696
    
    
    // START: IdentityMapUserDocumentStorage257835696
    public class IdentityMapUserDocumentStorage257835696 : Marten.Internal.Storage.IdentityMapDocumentStorage<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapUserDocumentStorage257835696(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(BarberScheduler.Domain.Aggregates.Users.User document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(BarberScheduler.Domain.Aggregates.Users.User document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapUserSelector257835696(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapUserDocumentStorage257835696
    
    
    // START: DirtyTrackingUserDocumentStorage257835696
    public class DirtyTrackingUserDocumentStorage257835696 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingUserDocumentStorage257835696(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(BarberScheduler.Domain.Aggregates.Users.User document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertUserOperation257835696
            (
                document, Identity(document),
                session.Versions.ForType<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(BarberScheduler.Domain.Aggregates.Users.User document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(BarberScheduler.Domain.Aggregates.Users.User document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingUserSelector257835696(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingUserDocumentStorage257835696
    
    
    // START: UserBulkLoader257835696
    public class UserBulkLoader257835696 : Marten.Internal.CodeGeneration.BulkLoader<BarberScheduler.Domain.Aggregates.Users.User, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<BarberScheduler.Domain.Aggregates.Users.User, System.Guid> _storage;

        public UserBulkLoader257835696(Marten.Internal.Storage.IDocumentStorage<BarberScheduler.Domain.Aggregates.Users.User, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY marten_documentdb.mt_doc_users(\"user_name\", \"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_users_temp(\"user_name\", \"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into marten_documentdb.mt_doc_users (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", \"user_name\", mt_last_modified) (select mt_doc_users_temp.\"id\", mt_doc_users_temp.\"data\", mt_doc_users_temp.\"mt_version\", mt_doc_users_temp.\"mt_dotnet_type\", mt_doc_users_temp.\"user_name\", transaction_timestamp() from mt_doc_users_temp left join marten_documentdb.mt_doc_users on mt_doc_users_temp.id = marten_documentdb.mt_doc_users.id where marten_documentdb.mt_doc_users.id is null)";

        public const string OVERWRITE_SQL = "update marten_documentdb.mt_doc_users target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, user_name = source.user_name, mt_last_modified = transaction_timestamp() FROM mt_doc_users_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_users_temp as select * from marten_documentdb.mt_doc_users limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, BarberScheduler.Domain.Aggregates.Users.User document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.UserName, NpgsqlTypes.NpgsqlDbType.Text);
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, BarberScheduler.Domain.Aggregates.Users.User document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.UserName, NpgsqlTypes.NpgsqlDbType.Text, cancellation);
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: UserBulkLoader257835696
    
    
    // START: UserProvider257835696
    public class UserProvider257835696 : Marten.Internal.Storage.DocumentProvider<BarberScheduler.Domain.Aggregates.Users.User>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UserProvider257835696(Marten.Schema.DocumentMapping mapping) : base(new UserBulkLoader257835696(new QueryOnlyUserDocumentStorage257835696(mapping)), new QueryOnlyUserDocumentStorage257835696(mapping), new LightweightUserDocumentStorage257835696(mapping), new IdentityMapUserDocumentStorage257835696(mapping), new DirtyTrackingUserDocumentStorage257835696(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: UserProvider257835696
    
    
}

