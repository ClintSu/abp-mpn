const ENV = {
  dev: {
    apiUrl: 'http://localhost:44323',
    oAuthConfig: {
      issuer: 'http://localhost:44323',
      clientId: 'Mpn_App',
      clientSecret: '1q2w3e*',
      scope: 'Mpn',
    },
    localization: {
      defaultResourceName: 'Mpn',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44323',
    oAuthConfig: {
      issuer: 'http://localhost:44323',
      clientId: 'Mpn_App',
      clientSecret: '1q2w3e*',
      scope: 'Mpn',
    },
    localization: {
      defaultResourceName: 'Mpn',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
