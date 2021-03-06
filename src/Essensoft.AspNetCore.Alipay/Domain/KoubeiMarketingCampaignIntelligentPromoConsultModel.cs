using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoConsultModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoConsultModel : AlipayObject
    {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，尽量保持该字段足够复杂
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 当全场普通和单品普通方案时必传，体验方案不用传
        /// </summary>
        [JsonProperty("shop_ids")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 营销模板的编号，GENERAL_EXPERIENCE：全场体验；GENERAL_NORMAL：全场普通；ITEM_EXPERIENCE：单品体验；ITEM_NORMAL：单品普通
        /// </summary>
        [JsonProperty("template_code")]
        public string TemplateCode { get; set; }
    }
}
