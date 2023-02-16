
const yourIP = '172.20.7.111'; // See the docs https://docs.abp.io/en/abp/latest/Getting-Started-React-Native?Tiered=No
const port  = 44391;
const apiUrl = `http://${yourIP}:${port}`;
const ENV = {
  dev: {
    apiUrl: apiUrl,
    oAuthConfig: {
      issuer: apiUrl,
      clientId: 'ManagementApp_App',
      scope: 'offline_access ManagementApp',
      clientSecret: ''
    },
    localization: {
      defaultResourceName: 'ManagementApp',
    },
  },
  prod: {
    apiUrl: 'http://138.186.20.221:44354',
    oAuthConfig: {
      issuer: 'http://138.186.20.221:44354',
      clientId: 'ManagementApp_App',
      scope: 'offline_access ManagementApp',
    },
    localization: {
      defaultResourceName: 'ManagementApp',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
