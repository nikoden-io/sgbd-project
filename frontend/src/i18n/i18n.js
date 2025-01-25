import i18n from 'i18next'
import {initReactI18next} from 'react-i18next'

import Backend from 'i18next-http-backend'
import LanguageDetector from 'i18next-browser-languagedetector'

import * as enDemo from './locales/en/demo.json'
import * as frDemo from './locales/fr/demo.json'
import * as nlDemo from './locales/nl/demo.json'

i18n
  .use(Backend)
  .use(LanguageDetector)
  .use(initReactI18next)
  .init({
    fallbackLng: 'fr',
    lng: 'fr',
    debug: false,
    interpolation: {
      escapeValue: false
    },
    resources: {
      en: {
        demo: enDemo
      },
      fr: {
        demo: frDemo
      },
      nl: {
        demo: nlDemo
      }
    }
  })
  .then(() => {})

export default i18n
