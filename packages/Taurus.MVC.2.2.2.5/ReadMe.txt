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
	 <!--�Ƿ������������Ĭ��true-->
    <add key="IsAllowCORS" value="true"/>
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
2��Controllerȡ��ajaxResult���ԣ�����Write��������������ݡ�
V2.1.1.1
1������Token��֤���ԣ���DefautController�п��Զ��岢ʵ��Token��֤����2016-11-16����public static bool CheckToken(IController controller, string methodName){}��
2��Controller��ǿWrite���� (2016-11-30)
3��Controller����GetEntity<T>()���� (2016-11-30)
V2.2.0.0
1��Controller����GetJson()���� (2016-12-07)
2�����ӿ���֧��(2016-12-07)
3����ǿGetEntity<T>()����(2016-12-07)
V2.2.2.2
1������CYQ.Data(2017-02-04)
2������Session֧��(2017-02-04)

V2.2.2.5 (2017-02-28)
1������CYQ.Data
2���Ż�3�������Session�����򡢱��� ������ĳЩ��������쳣������