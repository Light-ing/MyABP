import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44349/',
  redirectUri: baseUrl,
  clientId: 'WCS_App',
  responseType: 'code',
  scope: 'offline_access WCS',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'WCS',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44349',
      rootNamespace: 'JinWang.WCS',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
