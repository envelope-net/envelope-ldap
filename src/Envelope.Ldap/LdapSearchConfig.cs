using System.DirectoryServices.Protocols;

namespace Envelope.Ldap;

public class LdapSearchConfig
{
	public string? DistinguishedName { get; set; }
	public string? LdapFilter { get; set; }
	public SearchScope SearchScope { get; set; } = SearchScope.Subtree;
	public List<string>? Attributes { get; set; }
	public int? MaxResultsToRequest { get; set; }
	public System.DirectoryServices.Protocols.SearchOption? SearchOptionsControl { get; set; }
}
