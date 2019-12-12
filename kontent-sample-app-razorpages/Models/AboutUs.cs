﻿
using Kentico.Kontent.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KenticoKontentModels
{
    public partial class AboutUs
    {
        public const string Codename = "about_us";
        public const string OurMottoCodename = "our_motto";
        public const string VideoCodename = "video";
        public const string MetadataOgDescriptionCodename = "metadata__og_description";
        public const string MetadataMetaTitleCodename = "metadata__meta_title";
        public const string MetadataOgTitleCodename = "metadata__og_title";
        public const string MetadataMetaDescriptionCodename = "metadata__meta_description";
        public const string MetadataTwitterSiteCodename = "metadata__twitter_site";
        public const string UrlPatternCodename = "url_pattern";
        public const string MetadataTwitterImageCodename = "metadata__twitter_image";
        public const string MetadataTwitterCreatorCodename = "metadata__twitter_creator";
        public const string MetadataTwitterTitleCodename = "metadata__twitter_title";
        public const string MetadataTwitterDescriptionCodename = "metadata__twitter_description";
        public const string MetadataOgImageCodename = "metadata__og_image";
        public const string FactsCodename = "facts";

        public string OurMotto { get; set; }
        public IEnumerable<HostedVideo> Video { get; set; }
        public string MetadataOgDescription { get; set; }
        public string MetadataMetaTitle { get; set; }
        public string MetadataOgTitle { get; set; }
        public string MetadataMetaDescription { get; set; }
        public string MetadataTwitterSite { get; set; }
        public string UrlPattern { get; set; }
        public IEnumerable<Asset> MetadataTwitterImage { get; set; }
        public string MetadataTwitterCreator { get; set; }
        public string MetadataTwitterTitle { get; set; }
        public string MetadataTwitterDescription { get; set; }
        public IEnumerable<Asset> MetadataOgImage { get; set; }
        public IEnumerable<FactAboutUs> Facts { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}
