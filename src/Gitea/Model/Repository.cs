/* 
 * Gitea API.
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 1.1.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Gitea.Client.OpenAPIDateConverter;

namespace Gitea.Model
{
    /// <summary>
    /// Repository represents a repository
    /// </summary>
    [DataContract]
    public partial class Repository :  IEquatable<Repository>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository" /> class.
        /// </summary>
        /// <param name="allowMergeCommits">allowMergeCommits.</param>
        /// <param name="allowRebase">allowRebase.</param>
        /// <param name="allowRebaseExplicit">allowRebaseExplicit.</param>
        /// <param name="allowSquashMerge">allowSquashMerge.</param>
        /// <param name="archived">archived.</param>
        /// <param name="avatarUrl">avatarUrl.</param>
        /// <param name="cloneUrl">cloneUrl.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="defaultBranch">defaultBranch.</param>
        /// <param name="description">description.</param>
        /// <param name="empty">empty.</param>
        /// <param name="externalTracker">externalTracker.</param>
        /// <param name="externalWiki">externalWiki.</param>
        /// <param name="fork">fork.</param>
        /// <param name="forksCount">forksCount.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="hasIssues">hasIssues.</param>
        /// <param name="hasPullRequests">hasPullRequests.</param>
        /// <param name="hasWiki">hasWiki.</param>
        /// <param name="htmlUrl">htmlUrl.</param>
        /// <param name="id">id.</param>
        /// <param name="ignoreWhitespaceConflicts">ignoreWhitespaceConflicts.</param>
        /// <param name="_internal">_internal.</param>
        /// <param name="internalTracker">internalTracker.</param>
        /// <param name="mirror">mirror.</param>
        /// <param name="name">name.</param>
        /// <param name="openIssuesCount">openIssuesCount.</param>
        /// <param name="openPrCounter">openPrCounter.</param>
        /// <param name="originalUrl">originalUrl.</param>
        /// <param name="owner">owner.</param>
        /// <param name="parent">parent.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="_private">_private.</param>
        /// <param name="releaseCounter">releaseCounter.</param>
        /// <param name="size">size.</param>
        /// <param name="sshUrl">sshUrl.</param>
        /// <param name="starsCount">starsCount.</param>
        /// <param name="template">template.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="watchersCount">watchersCount.</param>
        /// <param name="website">website.</param>
        public Repository(bool allowMergeCommits = default(bool), bool allowRebase = default(bool), bool allowRebaseExplicit = default(bool), bool allowSquashMerge = default(bool), bool archived = default(bool), string avatarUrl = default(string), string cloneUrl = default(string), DateTime createdAt = default(DateTime), string defaultBranch = default(string), string description = default(string), bool empty = default(bool), ExternalTracker externalTracker = default(ExternalTracker), ExternalWiki externalWiki = default(ExternalWiki), bool fork = default(bool), long forksCount = default(long), string fullName = default(string), bool hasIssues = default(bool), bool hasPullRequests = default(bool), bool hasWiki = default(bool), string htmlUrl = default(string), long id = default(long), bool ignoreWhitespaceConflicts = default(bool), bool _internal = default(bool), InternalTracker internalTracker = default(InternalTracker), bool mirror = default(bool), string name = default(string), long openIssuesCount = default(long), long openPrCounter = default(long), string originalUrl = default(string), User owner = default(User), Repository parent = default(Repository), Permission permissions = default(Permission), bool _private = default(bool), long releaseCounter = default(long), long size = default(long), string sshUrl = default(string), long starsCount = default(long), bool template = default(bool), DateTime updatedAt = default(DateTime), long watchersCount = default(long), string website = default(string))
        {
            this.AllowMergeCommits = allowMergeCommits;
            this.AllowRebase = allowRebase;
            this.AllowRebaseExplicit = allowRebaseExplicit;
            this.AllowSquashMerge = allowSquashMerge;
            this.Archived = archived;
            this.AvatarUrl = avatarUrl;
            this.CloneUrl = cloneUrl;
            this.CreatedAt = createdAt;
            this.DefaultBranch = defaultBranch;
            this.Description = description;
            this.Empty = empty;
            this.ExternalTracker = externalTracker;
            this.ExternalWiki = externalWiki;
            this.Fork = fork;
            this.ForksCount = forksCount;
            this.FullName = fullName;
            this.HasIssues = hasIssues;
            this.HasPullRequests = hasPullRequests;
            this.HasWiki = hasWiki;
            this.HtmlUrl = htmlUrl;
            this.Id = id;
            this.IgnoreWhitespaceConflicts = ignoreWhitespaceConflicts;
            this.Internal = _internal;
            this.InternalTracker = internalTracker;
            this.Mirror = mirror;
            this.Name = name;
            this.OpenIssuesCount = openIssuesCount;
            this.OpenPrCounter = openPrCounter;
            this.OriginalUrl = originalUrl;
            this.Owner = owner;
            this.Parent = parent;
            this.Permissions = permissions;
            this.Private = _private;
            this.ReleaseCounter = releaseCounter;
            this.Size = size;
            this.SshUrl = sshUrl;
            this.StarsCount = starsCount;
            this.Template = template;
            this.UpdatedAt = updatedAt;
            this.WatchersCount = watchersCount;
            this.Website = website;
        }
        
        /// <summary>
        /// Gets or Sets AllowMergeCommits
        /// </summary>
        [DataMember(Name="allow_merge_commits", EmitDefaultValue=false)]
        public bool AllowMergeCommits { get; set; }

        /// <summary>
        /// Gets or Sets AllowRebase
        /// </summary>
        [DataMember(Name="allow_rebase", EmitDefaultValue=false)]
        public bool AllowRebase { get; set; }

        /// <summary>
        /// Gets or Sets AllowRebaseExplicit
        /// </summary>
        [DataMember(Name="allow_rebase_explicit", EmitDefaultValue=false)]
        public bool AllowRebaseExplicit { get; set; }

        /// <summary>
        /// Gets or Sets AllowSquashMerge
        /// </summary>
        [DataMember(Name="allow_squash_merge", EmitDefaultValue=false)]
        public bool AllowSquashMerge { get; set; }

        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Gets or Sets CloneUrl
        /// </summary>
        [DataMember(Name="clone_url", EmitDefaultValue=false)]
        public string CloneUrl { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DefaultBranch
        /// </summary>
        [DataMember(Name="default_branch", EmitDefaultValue=false)]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name="empty", EmitDefaultValue=false)]
        public bool Empty { get; set; }

        /// <summary>
        /// Gets or Sets ExternalTracker
        /// </summary>
        [DataMember(Name="external_tracker", EmitDefaultValue=false)]
        public ExternalTracker ExternalTracker { get; set; }

        /// <summary>
        /// Gets or Sets ExternalWiki
        /// </summary>
        [DataMember(Name="external_wiki", EmitDefaultValue=false)]
        public ExternalWiki ExternalWiki { get; set; }

        /// <summary>
        /// Gets or Sets Fork
        /// </summary>
        [DataMember(Name="fork", EmitDefaultValue=false)]
        public bool Fork { get; set; }

        /// <summary>
        /// Gets or Sets ForksCount
        /// </summary>
        [DataMember(Name="forks_count", EmitDefaultValue=false)]
        public long ForksCount { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets HasIssues
        /// </summary>
        [DataMember(Name="has_issues", EmitDefaultValue=false)]
        public bool HasIssues { get; set; }

        /// <summary>
        /// Gets or Sets HasPullRequests
        /// </summary>
        [DataMember(Name="has_pull_requests", EmitDefaultValue=false)]
        public bool HasPullRequests { get; set; }

        /// <summary>
        /// Gets or Sets HasWiki
        /// </summary>
        [DataMember(Name="has_wiki", EmitDefaultValue=false)]
        public bool HasWiki { get; set; }

        /// <summary>
        /// Gets or Sets HtmlUrl
        /// </summary>
        [DataMember(Name="html_url", EmitDefaultValue=false)]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreWhitespaceConflicts
        /// </summary>
        [DataMember(Name="ignore_whitespace_conflicts", EmitDefaultValue=false)]
        public bool IgnoreWhitespaceConflicts { get; set; }

        /// <summary>
        /// Gets or Sets Internal
        /// </summary>
        [DataMember(Name="internal", EmitDefaultValue=false)]
        public bool Internal { get; set; }

        /// <summary>
        /// Gets or Sets InternalTracker
        /// </summary>
        [DataMember(Name="internal_tracker", EmitDefaultValue=false)]
        public InternalTracker InternalTracker { get; set; }

        /// <summary>
        /// Gets or Sets Mirror
        /// </summary>
        [DataMember(Name="mirror", EmitDefaultValue=false)]
        public bool Mirror { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OpenIssuesCount
        /// </summary>
        [DataMember(Name="open_issues_count", EmitDefaultValue=false)]
        public long OpenIssuesCount { get; set; }

        /// <summary>
        /// Gets or Sets OpenPrCounter
        /// </summary>
        [DataMember(Name="open_pr_counter", EmitDefaultValue=false)]
        public long OpenPrCounter { get; set; }

        /// <summary>
        /// Gets or Sets OriginalUrl
        /// </summary>
        [DataMember(Name="original_url", EmitDefaultValue=false)]
        public string OriginalUrl { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public User Owner { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public Repository Parent { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public Permission Permissions { get; set; }

        /// <summary>
        /// Gets or Sets Private
        /// </summary>
        [DataMember(Name="private", EmitDefaultValue=false)]
        public bool Private { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseCounter
        /// </summary>
        [DataMember(Name="release_counter", EmitDefaultValue=false)]
        public long ReleaseCounter { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long Size { get; set; }

        /// <summary>
        /// Gets or Sets SshUrl
        /// </summary>
        [DataMember(Name="ssh_url", EmitDefaultValue=false)]
        public string SshUrl { get; set; }

        /// <summary>
        /// Gets or Sets StarsCount
        /// </summary>
        [DataMember(Name="stars_count", EmitDefaultValue=false)]
        public long StarsCount { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public bool Template { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets WatchersCount
        /// </summary>
        [DataMember(Name="watchers_count", EmitDefaultValue=false)]
        public long WatchersCount { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Repository {\n");
            sb.Append("  AllowMergeCommits: ").Append(AllowMergeCommits).Append("\n");
            sb.Append("  AllowRebase: ").Append(AllowRebase).Append("\n");
            sb.Append("  AllowRebaseExplicit: ").Append(AllowRebaseExplicit).Append("\n");
            sb.Append("  AllowSquashMerge: ").Append(AllowSquashMerge).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  CloneUrl: ").Append(CloneUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DefaultBranch: ").Append(DefaultBranch).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("  ExternalTracker: ").Append(ExternalTracker).Append("\n");
            sb.Append("  ExternalWiki: ").Append(ExternalWiki).Append("\n");
            sb.Append("  Fork: ").Append(Fork).Append("\n");
            sb.Append("  ForksCount: ").Append(ForksCount).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  HasIssues: ").Append(HasIssues).Append("\n");
            sb.Append("  HasPullRequests: ").Append(HasPullRequests).Append("\n");
            sb.Append("  HasWiki: ").Append(HasWiki).Append("\n");
            sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IgnoreWhitespaceConflicts: ").Append(IgnoreWhitespaceConflicts).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  InternalTracker: ").Append(InternalTracker).Append("\n");
            sb.Append("  Mirror: ").Append(Mirror).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenIssuesCount: ").Append(OpenIssuesCount).Append("\n");
            sb.Append("  OpenPrCounter: ").Append(OpenPrCounter).Append("\n");
            sb.Append("  OriginalUrl: ").Append(OriginalUrl).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  ReleaseCounter: ").Append(ReleaseCounter).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  SshUrl: ").Append(SshUrl).Append("\n");
            sb.Append("  StarsCount: ").Append(StarsCount).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  WatchersCount: ").Append(WatchersCount).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Repository);
        }

        /// <summary>
        /// Returns true if Repository instances are equal
        /// </summary>
        /// <param name="input">Instance of Repository to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Repository input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowMergeCommits == input.AllowMergeCommits ||
                    (this.AllowMergeCommits != null &&
                    this.AllowMergeCommits.Equals(input.AllowMergeCommits))
                ) && 
                (
                    this.AllowRebase == input.AllowRebase ||
                    (this.AllowRebase != null &&
                    this.AllowRebase.Equals(input.AllowRebase))
                ) && 
                (
                    this.AllowRebaseExplicit == input.AllowRebaseExplicit ||
                    (this.AllowRebaseExplicit != null &&
                    this.AllowRebaseExplicit.Equals(input.AllowRebaseExplicit))
                ) && 
                (
                    this.AllowSquashMerge == input.AllowSquashMerge ||
                    (this.AllowSquashMerge != null &&
                    this.AllowSquashMerge.Equals(input.AllowSquashMerge))
                ) && 
                (
                    this.Archived == input.Archived ||
                    (this.Archived != null &&
                    this.Archived.Equals(input.Archived))
                ) && 
                (
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.CloneUrl == input.CloneUrl ||
                    (this.CloneUrl != null &&
                    this.CloneUrl.Equals(input.CloneUrl))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DefaultBranch == input.DefaultBranch ||
                    (this.DefaultBranch != null &&
                    this.DefaultBranch.Equals(input.DefaultBranch))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Empty == input.Empty ||
                    (this.Empty != null &&
                    this.Empty.Equals(input.Empty))
                ) && 
                (
                    this.ExternalTracker == input.ExternalTracker ||
                    (this.ExternalTracker != null &&
                    this.ExternalTracker.Equals(input.ExternalTracker))
                ) && 
                (
                    this.ExternalWiki == input.ExternalWiki ||
                    (this.ExternalWiki != null &&
                    this.ExternalWiki.Equals(input.ExternalWiki))
                ) && 
                (
                    this.Fork == input.Fork ||
                    (this.Fork != null &&
                    this.Fork.Equals(input.Fork))
                ) && 
                (
                    this.ForksCount == input.ForksCount ||
                    (this.ForksCount != null &&
                    this.ForksCount.Equals(input.ForksCount))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.HasIssues == input.HasIssues ||
                    (this.HasIssues != null &&
                    this.HasIssues.Equals(input.HasIssues))
                ) && 
                (
                    this.HasPullRequests == input.HasPullRequests ||
                    (this.HasPullRequests != null &&
                    this.HasPullRequests.Equals(input.HasPullRequests))
                ) && 
                (
                    this.HasWiki == input.HasWiki ||
                    (this.HasWiki != null &&
                    this.HasWiki.Equals(input.HasWiki))
                ) && 
                (
                    this.HtmlUrl == input.HtmlUrl ||
                    (this.HtmlUrl != null &&
                    this.HtmlUrl.Equals(input.HtmlUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IgnoreWhitespaceConflicts == input.IgnoreWhitespaceConflicts ||
                    (this.IgnoreWhitespaceConflicts != null &&
                    this.IgnoreWhitespaceConflicts.Equals(input.IgnoreWhitespaceConflicts))
                ) && 
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
                ) && 
                (
                    this.InternalTracker == input.InternalTracker ||
                    (this.InternalTracker != null &&
                    this.InternalTracker.Equals(input.InternalTracker))
                ) && 
                (
                    this.Mirror == input.Mirror ||
                    (this.Mirror != null &&
                    this.Mirror.Equals(input.Mirror))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpenIssuesCount == input.OpenIssuesCount ||
                    (this.OpenIssuesCount != null &&
                    this.OpenIssuesCount.Equals(input.OpenIssuesCount))
                ) && 
                (
                    this.OpenPrCounter == input.OpenPrCounter ||
                    (this.OpenPrCounter != null &&
                    this.OpenPrCounter.Equals(input.OpenPrCounter))
                ) && 
                (
                    this.OriginalUrl == input.OriginalUrl ||
                    (this.OriginalUrl != null &&
                    this.OriginalUrl.Equals(input.OriginalUrl))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.Private == input.Private ||
                    (this.Private != null &&
                    this.Private.Equals(input.Private))
                ) && 
                (
                    this.ReleaseCounter == input.ReleaseCounter ||
                    (this.ReleaseCounter != null &&
                    this.ReleaseCounter.Equals(input.ReleaseCounter))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.SshUrl == input.SshUrl ||
                    (this.SshUrl != null &&
                    this.SshUrl.Equals(input.SshUrl))
                ) && 
                (
                    this.StarsCount == input.StarsCount ||
                    (this.StarsCount != null &&
                    this.StarsCount.Equals(input.StarsCount))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.WatchersCount == input.WatchersCount ||
                    (this.WatchersCount != null &&
                    this.WatchersCount.Equals(input.WatchersCount))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AllowMergeCommits != null)
                    hashCode = hashCode * 59 + this.AllowMergeCommits.GetHashCode();
                if (this.AllowRebase != null)
                    hashCode = hashCode * 59 + this.AllowRebase.GetHashCode();
                if (this.AllowRebaseExplicit != null)
                    hashCode = hashCode * 59 + this.AllowRebaseExplicit.GetHashCode();
                if (this.AllowSquashMerge != null)
                    hashCode = hashCode * 59 + this.AllowSquashMerge.GetHashCode();
                if (this.Archived != null)
                    hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.CloneUrl != null)
                    hashCode = hashCode * 59 + this.CloneUrl.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DefaultBranch != null)
                    hashCode = hashCode * 59 + this.DefaultBranch.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Empty != null)
                    hashCode = hashCode * 59 + this.Empty.GetHashCode();
                if (this.ExternalTracker != null)
                    hashCode = hashCode * 59 + this.ExternalTracker.GetHashCode();
                if (this.ExternalWiki != null)
                    hashCode = hashCode * 59 + this.ExternalWiki.GetHashCode();
                if (this.Fork != null)
                    hashCode = hashCode * 59 + this.Fork.GetHashCode();
                if (this.ForksCount != null)
                    hashCode = hashCode * 59 + this.ForksCount.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.HasIssues != null)
                    hashCode = hashCode * 59 + this.HasIssues.GetHashCode();
                if (this.HasPullRequests != null)
                    hashCode = hashCode * 59 + this.HasPullRequests.GetHashCode();
                if (this.HasWiki != null)
                    hashCode = hashCode * 59 + this.HasWiki.GetHashCode();
                if (this.HtmlUrl != null)
                    hashCode = hashCode * 59 + this.HtmlUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IgnoreWhitespaceConflicts != null)
                    hashCode = hashCode * 59 + this.IgnoreWhitespaceConflicts.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
                if (this.InternalTracker != null)
                    hashCode = hashCode * 59 + this.InternalTracker.GetHashCode();
                if (this.Mirror != null)
                    hashCode = hashCode * 59 + this.Mirror.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpenIssuesCount != null)
                    hashCode = hashCode * 59 + this.OpenIssuesCount.GetHashCode();
                if (this.OpenPrCounter != null)
                    hashCode = hashCode * 59 + this.OpenPrCounter.GetHashCode();
                if (this.OriginalUrl != null)
                    hashCode = hashCode * 59 + this.OriginalUrl.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Private != null)
                    hashCode = hashCode * 59 + this.Private.GetHashCode();
                if (this.ReleaseCounter != null)
                    hashCode = hashCode * 59 + this.ReleaseCounter.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.SshUrl != null)
                    hashCode = hashCode * 59 + this.SshUrl.GetHashCode();
                if (this.StarsCount != null)
                    hashCode = hashCode * 59 + this.StarsCount.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.WatchersCount != null)
                    hashCode = hashCode * 59 + this.WatchersCount.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                return hashCode;
            }
        }
    }

}
