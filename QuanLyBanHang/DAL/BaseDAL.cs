using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.DAL
{
    public class BaseDAL
    {
        protected readonly string prefix = "C##SCOTT.";
        private readonly string OracleExceptionMessage = $"Lỗi kết nối với Oracle Database!" +
                    $"{Environment.NewLine}" +
                    $"Xin liên hệ với admin!";
        protected OracleConnection con;
        protected void XyLyNgoaiLe(Action @action)
        {
            try
            {
                con = ConnectionManager.Connect();
                action();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(OracleExceptionMessage);
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Lỗi: {exception.Message}");
            }
            finally
            {
                ConnectionManager.Disconnect();
            }
        }

        protected T XyLyNgoaiLe<T>(Func<T> @func)
        {
            try
            {
                con = ConnectionManager.Connect();
                return func();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(OracleExceptionMessage);
                return default(T);
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Lỗi : {exception.Message}");
                return default(T);
            }
            finally
            {
                ConnectionManager.Disconnect();
            }
        }
    }

    public static class DALExtensions
    {
        public static OracleCommand CreateCustomCommand(this OracleConnection _con)
        {
            var cmd = _con.CreateCommand();
            cmd.CommandTimeout = 15;
            return cmd;
        }
    }
}
