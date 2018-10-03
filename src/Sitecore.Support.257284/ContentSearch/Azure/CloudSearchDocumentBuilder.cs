namespace Sitecore.Support.ContentSearch.Azure
{
  using Sitecore.ContentSearch;

  public class CloudSearchDocumentBuilder : Sitecore.ContentSearch.Azure.CloudSearchDocumentBuilder
  {
    public CloudSearchDocumentBuilder(IIndexable indexable, IProviderUpdateContext context) : base(indexable, context)
    {
    }

    /// <inheritdoc/>
    public override void AddItemFields()
    {
      base.AddItemFields();
    }
  }
}