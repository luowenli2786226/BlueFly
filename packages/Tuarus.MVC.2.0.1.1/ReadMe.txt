1������ʾ�� ��http://taurus.cyqdata.com
2����Դ��ַ ��https://github.com/cyq1162/Taurus.MVC
3��CYQ.Data ��Դ��ַ: https://github.com/cyq1162/cyqdata

ʹ��ע�����
1�������ļ�˵��
<configuration>
  <appSettings>
    <!--ָ�����������ڵ���Ŀ��Dll������-->
    <add key="Taurus.Controllers" value="Taurus.Controllers" />
    <!--ָ������ĺ�׺��Ĭ���޺�׺��������.shtml��-->
    <add key="Taurus.Suffix" value=""/>
    <!--·��ģʽ��ֵΪ0,1��2��[Ĭ��Ϊ1]
      ֵΪ0��ƥ��{Action}/{Para}
      ֵΪ1��ƥ��{Controller}/{Action}/{Para}
      ֵΪ2��ƥ��{Module}/{Controller}/{Action}/{Para}-->
    <add key="RouteMode" value="1"/>
  </appSettings>
  <system.web>
    <httpModules>
      <!--Taurus IISӦ�ó���أ�����ģʽ�������У����������ã���֮��ע�͵����У�-->
			<add name="Taurus.Core" type="Taurus.Core.UrlRewrite,Taurus.Core" />
    </httpModules>
  </system.web>
  <system.webServer>
    <modules>
      <!--Taurus IISӦ�ó���أ�����ģʽ�������У����������ã���֮��ע�͵����У�-->
      <add name="Taurus.Core" type="Taurus.Core.UrlRewrite,Taurus.Core" />
    </modules>
  </system.webServer>
</configuration>

A����Ŀ��Ҫ�ж�Ӧ��Controller��Ŀ��Ĭ�ϵ����õ���Ŀ���ƣ�Taurus.Controllers
B����������ģʽע�͵�Taurus.Core���õ�����һ����

������־��
1������CYQ.Data �汾��
2��ȡ��ajaxResult���ԣ�����Write��������������ݡ�
3��Write����������������Զ�תJson����2016-11-16��
4������Token��֤���ԣ���DefautController�п��Զ��岢ʵ��Token��֤����2016-11-16��
public static bool CheckToken(IController controller, string methodName){}