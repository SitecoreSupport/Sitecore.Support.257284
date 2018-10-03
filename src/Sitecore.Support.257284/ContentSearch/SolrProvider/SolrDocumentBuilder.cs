namespace Sitecore.Support.ContentSearch.SolrProvider
{
  using Sitecore.ContentSearch;
  public class SolrDocumentBuilder : Sitecore.ContentSearch.SolrProvider.SolrDocumentBuilder
  {
    public SolrDocumentBuilder(IIndexable indexable, IProviderUpdateContext context) : base(indexable, context)
    {
    }

    /// <inheritdoc/>
    public override void AddItemFields()
    {
      base.AddItemFields();
    }
  }
}