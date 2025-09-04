using Aspose.Pdf.Cloud.Sdk.Model;

namespace Tables
{
    public class TableCreate
    {
        public static Table New()
        {
            int num_of_cols = 5;
            int num_of_rows = 5;

            TextState header_text_state = new TextState(
                Font: "Arial Bold",
                FontSize: 11,
                ForegroundColor: new Color(A: 255, R: 255, G: 255, B: 255),
                FontStyle: FontStyles.Bold);

            TextState common_text_state = new TextState(
                Font: "Arial Bold",
                FontSize: 11,
                ForegroundColor: new Color(A: 255, R: 112, G: 112, B: 112),
                FontStyle: FontStyles.Regular);

            string col_widths = string.Empty;
            for (int col_index = 0; col_index < num_of_cols; col_index++)
            {
                col_widths += " 70";
            }

            List<Row> table_rows = new List<Row>();
            GraphInfo border_table_border = new GraphInfo(
                Color: new Color(A: 255, R: 0, G: 255, B: 0),
                LineWidth: 0.5);

            for (int row_index = 0; row_index < num_of_rows; row_index++)
            {
                List<Cell> row_cells = new List<Cell>();

                for (int col_index = 0; col_index < num_of_cols; col_index++)
                {
                    Cell cell = new Cell(DefaultCellTextState: common_text_state, Paragraphs: new List<TextRect>());
                    if (row_index == 0)
                    { // header cells
                        cell.BackgroundColor = new Color(A: 255, R: 128, G: 128, B: 128);
                        cell.DefaultCellTextState = header_text_state;
                    }
                    else
                    {
                        cell.BackgroundColor = new Color(A: 255, R: 255, G: 255, B: 255);
                        cell.DefaultCellTextState = common_text_state;
                    };

                    TextRect text_rect = new TextRect();
                    if (row_index == 0)
                    {
                        text_rect.Text = "header #" + col_index.ToString();
                    }
                    else
                        text_rect.Text = string.Format("value '{0}', '{1}'", row_index, col_index);

                    cell.Paragraphs.Add(text_rect);

                    row_cells.Add(cell);
                }

                Row row = new Row(Cells: row_cells);
                table_rows.Add(row);
            }
            Table table = new Table(Left: 150, Top: 250, ColumnWidths: col_widths, Rows: table_rows);
            table.DefaultCellBorder = new BorderInfo(
                Top: border_table_border,
                Right: border_table_border,
                Bottom: border_table_border,
                Left: border_table_border,
                RoundedBorderRadius: 2);

            return table;
        }
    }
}
