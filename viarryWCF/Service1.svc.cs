using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace viarryWCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string getUserInput(string value)
        {
            return string.Format("您输入的内容是：{0}", value);
        }

        public object sqlComman(string value)
        {
            //创建数据库查询类
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=viarry;Integrated Security=True");
            connection.Open();//打开数据连接
            SqlCommand command = new SqlCommand(value, connection);//拼接命令脚本
            
            try
            {
                return command.ExecuteReader();
                connection.Close();//关闭连接
            }catch(Exception e)
            {
                return e;
            }
            
        }
    }
}
