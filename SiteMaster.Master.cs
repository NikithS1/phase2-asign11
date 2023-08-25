using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace YourNamespace
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load articles on initial page load
                LoadArticles();
            }
        }

        private void LoadArticles()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ArticleId, Title, Content, PublishDate FROM Articles";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Use the reader to populate your UI elements or store data
                // For example, bind data to a GridView or Repeater control
                // gridView.DataSource = reader;
                // gridView.DataBind();

                reader.Close();
            }
        }
    }
}
