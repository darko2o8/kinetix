﻿using Kinetix.ServiceModel;

namespace Kinetix.Search.Model {

    /// <summary>
    /// Facette de référence.
    /// </summary>
    /// <typeparam name="T">Type de la référence.</typeparam>
    public class ReferenceFacet<T> : IFacetDefinition {

        /// <inheritdoc />
        public string FieldName {
            get;
            set;
        }

        /// <inheritdoc />
        public string Name {
            get;
            set;
        }

        /// <inheritdoc cref="IFacetDefinition.ResolveLabel" />
        public string ResolveLabel(object primaryKey) {
            return ReferenceManager.Instance.GetReferenceValueByPrimaryKey<T>(primaryKey);
        }
    }
}
