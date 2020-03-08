﻿// Author: Dominic Beger (Trade/ProgTrade) 2017

using nUpdate.Administration.Models.Http;

namespace nUpdate.Administration.Models
{
    public class ProjectCreationData
    {
        /// <summary>
        ///     Gets or sets the location (directory path) of the project.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        ///     Gets or sets the private key associated with the project.
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        ///     Gets or sets the update provider enumeration type for the wizard.
        /// </summary>
        public UpdateProviderType UpdateProviderType { get; set; }

        public HttpBackendType HttpBackendType { get; set; }

        /// <summary>
        ///     Gets or sets the project data.
        /// </summary>
        public UpdateProject Project { get; set; } = new UpdateProject();
    }
}