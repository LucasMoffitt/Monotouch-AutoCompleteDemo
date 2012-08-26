using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AutoCompleteDemo {

	public class AutoCompleteTableSource : UITableViewSource {
		protected string[] suggestions;
		protected string cellIdentifier = "suggestionCell";
		
		AutoCompleteDemoViewController controllerContext;

		public AutoCompleteTableSource (string[] suggestions, AutoCompleteDemoViewController controllerContext) {
			this.suggestions = suggestions;
			this.controllerContext = controllerContext;
		}

		public override int RowsInSection (UITableView tableview, int section) {
			return suggestions.Length;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath) {
			controllerContext.SetAutoCompleteText(suggestions[indexPath.Row]);
			tableView.DeselectRow (indexPath, true);
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath) {
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			
			var cellStyle = UITableViewCellStyle.Default;
			if (cell == null) {
				cell = new UITableViewCell (cellStyle, cellIdentifier);
			}
			cell.TextLabel.Text = suggestions[indexPath.Row];
			return cell;
		}
	}
}

