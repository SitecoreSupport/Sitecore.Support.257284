namespace Sitecore.Support.ContentSearch.LuceneProvider
{
  using Sitecore.ContentSearch;
  public class LuceneDocumentBuilder : Sitecore.ContentSearch.LuceneProvider.LuceneDocumentBuilder
  {
    public LuceneDocumentBuilder(IIndexable indexable, IProviderUpdateContext context) : base(indexable, context)
    {
    }

    /// <inheritdoc/>
    public override void AddItemFields()
    {
      this.Indexable.LoadAllFields();
      base.AddItemFields();
    }
  }
}