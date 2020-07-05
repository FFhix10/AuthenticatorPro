﻿using System.Collections.Generic;
using System.Linq;

namespace AuthenticatorPro.Shared.Data
{
    public static class Icon
    {
        public static readonly Dictionary<string, int> Service = new Dictionary<string, int> 
        {
            {"default", Resource.Drawable.auth_default},
            {"1and1", Resource.Drawable.auth_1and1},
            {"1password", Resource.Drawable.auth_1password},
            {"3cx", Resource.Drawable.auth_3cx},
            {"adafruit", Resource.Drawable.auth_adafruit},
            {"adguard", Resource.Drawable.auth_adguard},
            {"adobe", Resource.Drawable.auth_adobe},
            {"algolia", Resource.Drawable.auth_algolia},
            {"amazon", Resource.Drawable.auth_amazon},
            {"atlassian", Resource.Drawable.auth_atlassian},
            {"anycoindirect", Resource.Drawable.auth_anycoindirect},
            {"appveyor", Resource.Drawable.auth_appveyor},
            {"arubacloud", Resource.Drawable.auth_arubacloud},
            {"aws", Resource.Drawable.auth_aws},
            {"azure", Resource.Drawable.auth_azure},
            {"backblaze", Resource.Drawable.auth_backblaze},
            {"binance", Resource.Drawable.auth_binance},
            {"bitbucket", Resource.Drawable.auth_bitbucket},
            {"bitcoin", Resource.Drawable.auth_bitcoin},
            {"bitfinex", Resource.Drawable.auth_bitfinex},
            {"bitpay", Resource.Drawable.auth_bitpay},
            {"bitwarden", Resource.Drawable.auth_bitwarden},
            {"blizzard", Resource.Drawable.auth_blizzard},
            {"blockchain", Resource.Drawable.auth_blockchain},
            {"borgbase", Resource.Drawable.auth_borgbase},
            {"cachet", Resource.Drawable.auth_cachet},
            {"cexio", Resource.Drawable.auth_cexio},
            {"cloudflare", Resource.Drawable.auth_cloudflare},
            {"codeship", Resource.Drawable.auth_codeship},
            {"coinbase", Resource.Drawable.auth_coinbase},
            {"confluence", Resource.Drawable.auth_confluence},
            {"dashlane", Resource.Drawable.auth_dashlane},
            {"digitalocean", Resource.Drawable.auth_digitalocean},
            {"discord", Resource.Drawable.auth_discord},
            {"docker", Resource.Drawable.auth_docker},
            {"dropbox", Resource.Drawable.auth_dropbox},
            {"drupal", Resource.Drawable.auth_drupal},
            {"electronicarts", Resource.Drawable.auth_electronicarts},
            {"epicgames", Resource.Drawable.auth_epicgames},
            {"etsy", Resource.Drawable.auth_etsy},
            {"evernote", Resource.Drawable.auth_evernote},
            {"facebook", Resource.Drawable.auth_facebook},
            {"figma", Resource.Drawable.auth_figma},
            {"firefox", Resource.Drawable.auth_firefox},
            {"gandi", Resource.Drawable.auth_gandi},
            {"github", Resource.Drawable.auth_github},
            {"gitlab", Resource.Drawable.auth_gitlab},
            {"gmail", Resource.Drawable.auth_gmail},
            {"godaddy", Resource.Drawable.auth_godaddy},
            {"google", Resource.Drawable.auth_google},
            {"googlecloudplatform", Resource.Drawable.auth_googlecloudplatform},
            {"googledrive", Resource.Drawable.auth_googledrive},
            {"googleplay", Resource.Drawable.auth_googleplay},
            {"grammarly", Resource.Drawable.auth_grammarly},
            {"guildwars2", Resource.Drawable.auth_guildwars2},
            {"hangouts", Resource.Drawable.auth_hangouts},
            {"heroku", Resource.Drawable.auth_heroku},
            {"hetzner", Resource.Drawable.auth_hetzner},
            {"humblebundle", Resource.Drawable.auth_humblebundle},
            {"ifttt", Resource.Drawable.auth_ifttt},
            {"instagram", Resource.Drawable.auth_instagram},
            {"inwx", Resource.Drawable.auth_inwx},
            {"jetbrains", Resource.Drawable.auth_jetbrains},
            {"jira", Resource.Drawable.auth_jira},
            {"jiraservicedesk", Resource.Drawable.auth_jiraservicedesk},
            {"jottacloud", Resource.Drawable.auth_jottacloud},
            {"keeper", Resource.Drawable.auth_keeper},
            {"kickstarter", Resource.Drawable.auth_kickstarter},
            {"kraken", Resource.Drawable.auth_kraken},
            {"lastpass", Resource.Drawable.auth_lastpass},
            {"leaseweb", Resource.Drawable.auth_leaseweb},
            {"linkedin", Resource.Drawable.auth_linkedin},
            {"linode", Resource.Drawable.auth_linode},
            {"logmein", Resource.Drawable.auth_logmein},
            {"mailchimp", Resource.Drawable.auth_mailchimp},
            {"mailgun", Resource.Drawable.auth_mailgun},
            {"mapbox", Resource.Drawable.auth_mapbox},
            {"mega", Resource.Drawable.auth_mega},
            {"microsoft", Resource.Drawable.auth_microsoft},
            {"namecheap", Resource.Drawable.auth_namecheap},
            {"newegg", Resource.Drawable.auth_newegg},
            {"nextcloud", Resource.Drawable.auth_nextcloud},
            {"nintendo", Resource.Drawable.auth_nintendo},
            {"npm", Resource.Drawable.auth_npm},
            {"office365", Resource.Drawable.auth_office365},
            {"onedrive", Resource.Drawable.auth_onedrive},
            {"opsgenie", Resource.Drawable.auth_opsgenie},
            {"origin", Resource.Drawable.auth_origin},
            {"outlook", Resource.Drawable.auth_outlook},
            {"ovh", Resource.Drawable.auth_ovh},
            {"parsec", Resource.Drawable.auth_parsec},
            {"paypal", Resource.Drawable.auth_paypal},
            {"pluralsight", Resource.Drawable.auth_pluralsight},
            {"privacy", Resource.Drawable.auth_privacy},
            {"privateinternetaccess", Resource.Drawable.auth_privateinternetaccess},
            {"protonmail", Resource.Drawable.auth_protonmail},
            {"protonvpn", Resource.Drawable.auth_protonvpn},
            {"proxmox", Resource.Drawable.auth_proxmox},
            {"rackspace", Resource.Drawable.auth_rackspace},
            {"realvnc", Resource.Drawable.auth_realvnc},
            {"reddit", Resource.Drawable.auth_reddit},
            {"roboform", Resource.Drawable.auth_roboform},
            {"rockstargames", Resource.Drawable.auth_rockstargames},
            {"salesforce", Resource.Drawable.auth_salesforce},
            {"samsung", Resource.Drawable.auth_samsung},
            {"scaleway", Resource.Drawable.auth_scaleway},
            {"skype", Resource.Drawable.auth_skype},
            {"slack", Resource.Drawable.auth_slack},
            {"snapchat", Resource.Drawable.auth_snapchat},
            {"statuspage", Resource.Drawable.auth_statuspage},
            {"stripe", Resource.Drawable.auth_stripe},
            {"solarwinds", Resource.Drawable.auth_solarwinds},
            {"synology", Resource.Drawable.auth_synology},
            {"teamviewer", Resource.Drawable.auth_teamviewer},
            {"time4vps", Resource.Drawable.auth_time4vps},
            {"trello", Resource.Drawable.auth_trello},
            {"tutanota", Resource.Drawable.auth_tutanota},
            {"twitch", Resource.Drawable.auth_twitch},
            {"twitter", Resource.Drawable.auth_twitter},
            {"uber", Resource.Drawable.auth_uber},
            {"ubisoft", Resource.Drawable.auth_ubisoft},
            {"unlockbase", Resource.Drawable.auth_unlockbase},
            {"uphold", Resource.Drawable.auth_uphold},
            {"uplay", Resource.Drawable.auth_uplay},
            {"uptimerobot", Resource.Drawable.auth_uptimerobot},
            {"vultr", Resource.Drawable.auth_vultr},
            {"wargaming", Resource.Drawable.auth_wargaming},
            {"wetransfer", Resource.Drawable.auth_wetransfer},
            {"wordpress", Resource.Drawable.auth_wordpress},
            {"xbox", Resource.Drawable.auth_xbox},
            {"youtube", Resource.Drawable.auth_youtube}
        };

        private static readonly Dictionary<string, int> ServiceDark = new Dictionary<string, int>
        {
            {"default", Resource.Drawable.auth_default_dark},

            {"3cx", Resource.Drawable.auth_3cx_dark},
            {"adafruit", Resource.Drawable.auth_adafruit_dark},
            {"adobe", Resource.Drawable.auth_adobe_dark},
            {"anycoindirect", Resource.Drawable.auth_anycoindirect},
            {"amazon", Resource.Drawable.auth_amazon_dark},
            {"borgbase", Resource.Drawable.auth_borgbase_dark},
            {"electronicarts", Resource.Drawable.auth_electronicarts_dark},
            {"github", Resource.Drawable.auth_github_dark},
            {"ifttt", Resource.Drawable.auth_ifttt_dark},
            {"jetbrains", Resource.Drawable.auth_jetbrains_dark},
            {"logmein", Resource.Drawable.auth_logmein_dark},
            {"synology", Resource.Drawable.auth_synology_dark},
            {"uber", Resource.Drawable.auth_uber_dark},
            {"ubisoft", Resource.Drawable.auth_ubisoft_dark},
            {"wetransfer", Resource.Drawable.auth_wetransfer_dark},
            {"wordpress", Resource.Drawable.auth_wordpress_dark},
            {"xbox", Resource.Drawable.auth_xbox_dark}
        };

        public static int GetService(string key, bool isDark)
        {
            if(isDark)
            {
                if(key == null)
                    return ServiceDark["default"];

                if(ServiceDark.ContainsKey(key))
                    return ServiceDark[key];

                return Service.ContainsKey(key) ? Service[key] : ServiceDark["default"];
            }

            if(key == null)
                return Service["default"];

            return Service.ContainsKey(key) ? Service[key] : Service["default"];
        }

        public static string FindServiceKeyByName(string name)
        {
            var key = name.ToLower().Split(' ')[0];
            return Service.Keys.Contains(key) ? key : "default";
        }
    }
}
