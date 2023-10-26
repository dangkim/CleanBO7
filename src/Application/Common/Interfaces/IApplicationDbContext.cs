using AutoMapper.Execution;
using AutoMapper;
using System;
using CleanBO7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using static System.Net.WebRequestMethods;

namespace CleanBO7.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    //DbSet<TodoList> TodoLists { get; }

    //DbSet<Product> Products { get; }

    DbSet<Admin> Admins { get; }

    DbSet<AdminForce> AdminForces { get; }

    DbSet<AdminLevel> AdminLevels { get; }

    DbSet<AdminRole> AdminRoles { get; }

    DbSet<AdminRoleProduct> AdminRoleProducts { get; }

    DbSet<Bet> Bets { get; }

    DbSet<BetBundle> BetBundles { get; }

    DbSet<BetsFast3> BetsFast3s { get; }

    DbSet<BetsKeno> BetsKenos { get; }

    DbSet<BetsLadder> BetsLadders { get; }

    DbSet<BetsLuckyDerby> BetsLuckyDerbies { get; }

    DbSet<BetsPayout> BetsPayouts { get; }

    DbSet<BetsPayoutFast3> BetsPayoutFast3s { get; }

    DbSet<BetsPayoutKeno> BetsPayoutKenos { get; }

    DbSet<BetsPayoutLadder> BetsPayoutLadders { get; }

    DbSet<BetsPayoutLuckyDerby> BetsPayoutLuckyDerbies { get; }

    DbSet<BetsPayoutPk10> BetsPayoutPk10s { get; }

    DbSet<BetsPayoutRp> BetsPayoutRps { get; }

    DbSet<BetsPayoutThaiLottery> BetsPayoutThaiLotteries { get; }

    DbSet<BetsPayoutVnlottery> BetsPayoutVnlotteries { get; }

    DbSet<BetsPayoutWukong> BetsPayoutWukongs { get; }

    DbSet<BetsPk10> BetsPk10s { get; }

    DbSet<BetsRp> BetsRps { get; }

    DbSet<BetsThaiLottery> BetsThaiLotteries { get; }

    DbSet<BetsVnlottery> BetsVnlotteries { get; }

    DbSet<BetsWukong> BetsWukongs { get; }

    DbSet<CurrenciesRateDetail> CurrenciesRateDetails { get; }

    DbSet<Currency> Currencies { get; }

    DbSet<CustomWalletRound> CustomWalletRounds { get; }

    DbSet<Dict> Dicts { get; }

    DbSet<DigitRiskBalancer> DigitRiskBalancers { get; }

    DbSet<Draw> Draws { get; }

    DbSet<DrawMemberAction> DrawMemberActions { get; }

    DbSet<DrawSummary> DrawSummaries { get; }

    DbSet<DrawSummaryDetail> DrawSummaryDetails { get; }

    DbSet<DrawsDetail> DrawsDetails { get; }

    DbSet<DrawsTrend> DrawsTrends { get; }

    DbSet<DynamicOdd> DynamicOdds { get; }

    DbSet<GameBet> GameBets { get; }

    DbSet<GameBetBundle> GameBetBundles { get; }

    DbSet<GeneralSetting> GeneralSettings { get; }

    DbSet<Language> Languages { get; }

    DbSet<LimitHistory> LimitHistories { get; }

    DbSet<LotteryJob> LotteryJobs { get; }

    DbSet<Domain.Entities.Member> Members { get; }

    DbSet<MemberBetProfile> MemberBetProfiles { get; }

    DbSet<MemberDetail> MemberDetails { get; }

    DbSet<MemberIp> MemberIps { get; }

    DbSet<MemberLimit> MemberLimits { get; }

    DbSet<MemberLimitProfile> MemberLimitProfiles { get; }

    DbSet<MemberLimitProfileSetting> MemberLimitProfileSettings { get; }

    DbSet<Notice> Notices { get; }

    DbSet<Product> Products { get; }

    DbSet<ProductAreaConfig> ProductAreaConfigs { get; }

    DbSet<ProductAreaConfigRule> ProductAreaConfigRules { get; }

    DbSet<ProductBetConfig> ProductBetConfigs { get; }

    DbSet<ProductBetConfigParlay> ProductBetConfigParlays { get; }

    DbSet<ProductBetConfigParlaySetting> ProductBetConfigParlaySettings { get; }

    DbSet<ProductBetType> ProductBetTypes { get; }

    DbSet<ProductCategory> ProductCategories { get; }

    DbSet<ProductCategoryConfig> ProductCategoryConfigs { get; }

    DbSet<ProductLimit> ProductLimits { get; }

    DbSet<ProductLimitDetail> ProductLimitDetails { get; }

    DbSet<ProductLimitGroup> ProductLimitGroups { get; }

    DbSet<ProductOdd> ProductOdds { get; }

    DbSet<ProductRestriction> ProductRestrictions { get; }

    DbSet<ProductSetting> ProductSettings { get; }

    DbSet<ProductTicketRestriction> ProductTicketRestrictions { get; }

    DbSet<ProviderBrand> ProviderBrands { get; }

    DbSet<ProviderBrandDomain> ProviderBrandDomains { get; }

    DbSet<Restriction> Restrictions { get; }

    DbSet<RiskBalancerTracking> RiskBalancerTrackings { get; }

    DbSet<Rtp> Rtps { get; }

    DbSet<Schedule> Schedules { get; }

    DbSet<SessionLess> SessionLesses { get; }

    DbSet<Spin> Spins { get; }

    DbSet<SysLog> SysLogs { get; }

    DbSet<TraderOnline> TraderOnlines { get; }

    DbSet<Trading> Tradings { get; }

    DbSet<TradingFast3> TradingFast3s { get; }

    DbSet<TradingKeno> TradingKenos { get; }

    DbSet<TradingLadder> TradingLadders { get; }

    DbSet<TradingLuckyDerby> TradingLuckyDerbies { get; }

    DbSet<TradingPayout> TradingPayouts { get; }

    DbSet<TradingPayoutFast3> TradingPayoutFast3s { get; }

    DbSet<TradingPayoutKeno> TradingPayoutKenos { get; }

    DbSet<TradingPayoutLadder> TradingPayoutLadders { get; }

    DbSet<TradingPayoutLuckyDerby> TradingPayoutLuckyDerbies { get; }

    DbSet<TradingPayoutPk10> TradingPayoutPk10s { get; }

    DbSet<TradingPayoutRp> TradingPayoutRps { get; }

    DbSet<TradingPayoutThaiLottery> TradingPayoutThaiLotteries { get; }

    DbSet<TradingPayoutVnlottery> TradingPayoutVnlotteries { get; }

    DbSet<TradingPayoutWukong> TradingPayoutWukongs { get; }

    DbSet<TradingPk10> TradingPk10s { get; }

    DbSet<TradingRp> TradingRps { get; }

    DbSet<TradingThaiLottery> TradingThaiLotteries { get; }

    DbSet<TradingVnlottery> TradingVnlotteries { get; }

    DbSet<TradingWukong> TradingWukongs { get; }

    DbSet<TrialPromotion> TrialPromotions { get; }

    DbSet<TrialPromotionCurrency> TrialPromotionCurrencies { get; }

    DbSet<TrialPromotionGame> TrialPromotionGames { get; }

    DbSet<TrialPromotionMember> TrialPromotionMembers { get; }

    DbSet<TrialPromotionMemberTransaction> TrialPromotionMemberTransactions { get; }

    DbSet<VAdminRoleProduct> VAdminRoleProducts { get; }

    DbSet<VB> VBs { get; }

    DbSet<VBfast3> VBfast3s { get; }

    DbSet<VBiLotto> VBiLottos { get; }

    DbSet<VBkeno> VBkenos { get; }

    DbSet<VBladder> VBladders { get; }

    DbSet<VBluckyDerby> VBluckyDerbies { get; }

    DbSet<VBp> VBps { get; }

    DbSet<VBp45day> VBp45days { get; }

    DbSet<VBpfast3> VBpfast3s { get; }

    DbSet<VBpfast345Day> VBpfast345Days { get; }

    DbSet<VBpiLotto> VBpiLottos { get; }

    DbSet<VBpiLotto45Day> VBpiLotto45Days { get; }

    DbSet<VBpk10> VBpk10s { get; }

    DbSet<VBpkeno> VBpkenos { get; }

    DbSet<VBpkeno45Day> VBpkeno45Days { get; }

    DbSet<VBpladder> VBpladders { get; }

    DbSet<VBpladder45Day> VBpladder45Days { get; }

    DbSet<VBpluckyDerby> VBpluckyDerbies { get; }

    DbSet<VBpluckyDerby45Day> VBpluckyDerby45Days { get; }

    DbSet<VBppk10> VBppk10s { get; }

    DbSet<VBppk1045day> VBppk1045days { get; }

    DbSet<VBprp> VBprps { get; }

    DbSet<VBprps45day> VBprps45days { get; }

    DbSet<VBpthaiLottery> VBpthaiLotteries { get; }

    DbSet<VBpthaiLottery45Day> VBpthaiLottery45Days { get; }

    DbSet<VBpvnlottery> VBpvnlotteries { get; }

    DbSet<VBpvnlottery45Day> VBpvnlottery45Days { get; }

    DbSet<VBpwukong> VBpwukongs { get; }

    DbSet<VBpwukong45Day> VBpwukong45Days { get; }

    DbSet<VBrp> VBrps { get; }

    DbSet<VBthaiLottery> VBthaiLotteries { get; }

    DbSet<VBvnlottery> VBvnlotteries { get; }

    DbSet<VBwukong> VBwukongs { get; }

    DbSet<VCurrency> VCurrencies { get; }

    DbSet<VDraw> VDraws { get; }

    DbSet<VMember> VMembers { get; }

    DbSet<VProductBetConfig> VProductBetConfigs { get; }

    DbSet<VProductConfigType> VProductConfigTypes { get; }

    DbSet<VendorConfig> VendorConfigs { get; }

    DbSet<VendorConfigSideMenuSetting> VendorConfigSideMenuSettings { get; }

    DbSet<VendorCurrency> VendorCurrencies { get; }

    DbSet<VendorDomainBo> VendorDomainBos { get; }

    DbSet<VendorDomainBowhitelist> VendorDomainBowhitelists { get; }

    DbSet<VendorDomainFe> VendorDomainves { get; }

    DbSet<VendorLimitGroup> VendorLimitGroups { get; }

    DbSet<VendorLimitProfile> VendorLimitProfiles { get; }

    DbSet<VendorLimitProfileSetting> VendorLimitProfileSettings { get; }

    DbSet<VendorWalletConfig> VendorWalletConfigs { get; }

    DbSet<VendorWalletProductConfig> VendorWalletProductConfigs { get; }

    DbSet<WalletProduct> WalletProducts { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    public IQueryable<TResult> SqlQueryRaw<TResult>([NotParameterized] string sql, params object[] parameters);

}
