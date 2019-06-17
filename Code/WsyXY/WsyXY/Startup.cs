using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace WsyXY
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd";
            });
            services.AddOptions();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles(
                new StaticFileOptions()
                {
                    ServeUnknownFileTypes = true
                }
            );

            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            InitConfig();
        }

        public void InitConfig()
        {
            /*ConfigClass.ConnectionStr = Configuration.GetSection("DBCon").GetSection("ConnectionStr").Value;
            ConfigClass.RepairRoleID = Configuration.GetSection("RepairRoleID").Value;
            ConfigClass.RepairDeptID = Configuration.GetSection("RepairDeptID").Value;
            ConfigClass.ServiceRoleID = Configuration.GetSection("ServiceRoleID").Value;
            ConfigClass.IsOpenEmail = Configuration.GetSection("IsOpenEmail").Value;
            ConfigClass.EmailManagerAccount = Configuration.GetSection("EmailManagerAccount").Value;
            ConfigClass.EmailManagerPassWord = Configuration.GetSection("EmailManagerPassWord").Value;
            ConfigClass.WorkFlowAPIUrl = Configuration.GetSection("WorkFlowAPIUrl").Value;
            SqlHelper.CONN_STRING_NON_DTC = ConfigClass.ConnectionStr;
            string path = AppContext.BaseDirectory;
            //string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            ConfigClass.RootPath = path;
            // path = path + "\\DataSet\\" + "DBSql.xml";
            //path = path + "/DataSet/" + "DBSql.xml";
            path = Path.Combine(path, "DataSet", "DBSql.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                string id = item["id"].ToString();
                string sql = item["sql_text"].ToString();
                ConfigClass.DicConfig.Add(id, sql);
            }

            //…Ë÷√ª∫¥Ê
            CacheService.LoadCache();*/
        }
    }
}
