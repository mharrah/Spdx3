﻿// ReSharper disable UnusedMember.Global

namespace Spdx3.Model.Core.Enums;

/// <summary>
///     Information about the relationship between two Elements.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/RelationshipType/
/// </summary>
public enum RelationshipType
{
    affects,
    amendedBy,
    ancestorOf,
    availableFrom,
    configures,
    contains,
    coordinatedBy,
    copiedTo,
    delegatedTo,
    dependsOn,
    descendantOf,
    describes,
    doesNotAffect,
    expandsTo,
    exploitCreatedBy,
    fixedBy,
    fixedIn,
    foundBy,
    generates,
    hasAddedFile,
    hasAssessmentFor,
    hasAssociatedVulnerability,
    hasConcludedLicense,
    hasDataFile,
    hasDeclaredLicense,
    hasDeletedFile,
    hasDependencyManifest,
    hasDistributionArtifact,
    hasDocumentation,
    hasDynamicLink,
    hasEvidence,
    hasExample,
    hasHost,
    hasInput,
    hasMetadata,
    hasOptionalComponent,
    hasOptionalDependency,
    hasOutput,
    hasPrerequisite,
    hasProvidedDependency,
    hasRequirement,
    hasSpecification,
    hasStaticLink,
    hasTest,
    hasTestCase,
    hasVariant,
    invokedBy,
    modifiedBy,
    other,
    packagedBy,
    patchedBy,
    publishedBy,
    reportedBy,
    republishedBy,
    serializedInArtifact,
    testedOn,
    trainedOn,
    underInvestigationFor,
    usesTool
}