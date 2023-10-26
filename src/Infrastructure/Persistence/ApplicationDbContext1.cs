using System.Reflection;
using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Domain.Entities;
using CleanBO7.Infrastructure.Identity;
using CleanBO7.Infrastructure.Persistence.Interceptors;
using Duende.IdentityServer.EntityFramework.Options;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Options;
using System.Linq;

namespace CleanBO7.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    private readonly IMediator _mediator;
    private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IMediator mediator,
        AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor) 
        : base(options)
    {
        _mediator = mediator;
        _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
    }

    public DbSet<TodoList> TodoLists => Set<TodoList>();

    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    public DbSet<Admin> Admins => throw new NotImplementedException();

    public DbSet<AdminForce> AdminForces => throw new NotImplementedException();

    public DbSet<AdminLevel> AdminLevels => throw new NotImplementedException();

    public DbSet<AdminRole> AdminRoles => throw new NotImplementedException();

    public DbSet<AdminRoleProduct> AdminRoleProducts => throw new NotImplementedException();

    public DbSet<Bet> Bets => throw new NotImplementedException();

    public DbSet<BetBundle> BetBundles => throw new NotImplementedException();

    public DbSet<BetsFast3> BetsFast3s => throw new NotImplementedException();

    public DbSet<BetsKeno> BetsKenos => throw new NotImplementedException();

    public DbSet<BetsLadder> BetsLadders => throw new NotImplementedException();

    public DbSet<BetsLuckyDerby> BetsLuckyDerbies => throw new NotImplementedException();

    public DbSet<BetsPayout> BetsPayouts => throw new NotImplementedException();

    public DbSet<BetsPayoutFast3> BetsPayoutFast3s => throw new NotImplementedException();

    public DbSet<BetsPayoutKeno> BetsPayoutKenos => throw new NotImplementedException();

    public DbSet<BetsPayoutLadder> BetsPayoutLadders => throw new NotImplementedException();

    public DbSet<BetsPayoutLuckyDerby> BetsPayoutLuckyDerbies => throw new NotImplementedException();

    public DbSet<BetsPayoutPk10> BetsPayoutPk10s => throw new NotImplementedException();

    public DbSet<BetsPayoutRp> BetsPayoutRps => throw new NotImplementedException();

    public DbSet<BetsPayoutThaiLottery> BetsPayoutThaiLotteries => throw new NotImplementedException();

    public DbSet<BetsPayoutVnlottery> BetsPayoutVnlotteries => throw new NotImplementedException();

    public DbSet<BetsPayoutWukong> BetsPayoutWukongs => throw new NotImplementedException();

    public DbSet<BetsPk10> BetsPk10s => throw new NotImplementedException();

    public DbSet<BetsRp> BetsRps => throw new NotImplementedException();

    public DbSet<BetsThaiLottery> BetsThaiLotteries => throw new NotImplementedException();

    public DbSet<BetsVnlottery> BetsVnlotteries => throw new NotImplementedException();

    public DbSet<BetsWukong> BetsWukongs => throw new NotImplementedException();

    public DbSet<CurrenciesRateDetail> CurrenciesRateDetails => throw new NotImplementedException();

    public DbSet<Currency> Currencies => throw new NotImplementedException();

    public DbSet<CustomWalletRound> CustomWalletRounds => throw new NotImplementedException();

    public DbSet<Dict> Dicts => throw new NotImplementedException();

    public DbSet<DigitRiskBalancer> DigitRiskBalancers => throw new NotImplementedException();

    public DbSet<Draw> Draws => throw new NotImplementedException();

    public DbSet<DrawMemberAction> DrawMemberActions => throw new NotImplementedException();

    public DbSet<DrawSummary> DrawSummaries => throw new NotImplementedException();

    public DbSet<DrawSummaryDetail> DrawSummaryDetails => throw new NotImplementedException();

    public DbSet<DrawsDetail> DrawsDetails => throw new NotImplementedException();

    public DbSet<DrawsTrend> DrawsTrends => throw new NotImplementedException();

    public DbSet<DynamicOdd> DynamicOdds => throw new NotImplementedException();

    public DbSet<GameBet> GameBets => throw new NotImplementedException();

    public DbSet<GameBetBundle> GameBetBundles => throw new NotImplementedException();

    public DbSet<GeneralSetting> GeneralSettings => throw new NotImplementedException();

    public DbSet<Language> Languages => throw new NotImplementedException();

    public DbSet<LimitHistory> LimitHistories => throw new NotImplementedException();

    public DbSet<LotteryJob> LotteryJobs => throw new NotImplementedException();

    public DbSet<Member> Members => throw new NotImplementedException();

    public DbSet<MemberBetProfile> MemberBetProfiles => throw new NotImplementedException();

    public DbSet<MemberDetail> MemberDetails => throw new NotImplementedException();

    public DbSet<MemberIp> MemberIps => throw new NotImplementedException();

    public DbSet<MemberLimit> MemberLimits => throw new NotImplementedException();

    public DbSet<MemberLimitProfile> MemberLimitProfiles => throw new NotImplementedException();

    public DbSet<MemberLimitProfileSetting> MemberLimitProfileSettings => throw new NotImplementedException();

    public DbSet<Notice> Notices => throw new NotImplementedException();

    public DbSet<Product> Products => throw new NotImplementedException();

    public DbSet<ProductAreaConfig> ProductAreaConfigs => throw new NotImplementedException();

    public DbSet<ProductAreaConfigRule> ProductAreaConfigRules => throw new NotImplementedException();

    public DbSet<ProductBetConfig> ProductBetConfigs => throw new NotImplementedException();

    public DbSet<ProductBetConfigParlay> ProductBetConfigParlays => throw new NotImplementedException();

    public DbSet<ProductBetConfigParlaySetting> ProductBetConfigParlaySettings => throw new NotImplementedException();

    public DbSet<ProductBetType> ProductBetTypes => throw new NotImplementedException();

    public DbSet<ProductCategory> ProductCategories => throw new NotImplementedException();

    public DbSet<ProductCategoryConfig> ProductCategoryConfigs => throw new NotImplementedException();

    public DbSet<ProductLimit> ProductLimits => throw new NotImplementedException();

    public DbSet<ProductLimitDetail> ProductLimitDetails => throw new NotImplementedException();

    public DbSet<ProductLimitGroup> ProductLimitGroups => throw new NotImplementedException();

    public DbSet<ProductOdd> ProductOdds => throw new NotImplementedException();

    public DbSet<ProductRestriction> ProductRestrictions => throw new NotImplementedException();

    public DbSet<ProductSetting> ProductSettings => throw new NotImplementedException();

    public DbSet<ProductTicketRestriction> ProductTicketRestrictions => throw new NotImplementedException();

    public DbSet<ProviderBrand> ProviderBrands => throw new NotImplementedException();

    public DbSet<ProviderBrandDomain> ProviderBrandDomains => throw new NotImplementedException();

    public DbSet<Restriction> Restrictions => throw new NotImplementedException();

    public DbSet<RiskBalancerTracking> RiskBalancerTrackings => throw new NotImplementedException();

    public DbSet<Rtp> Rtps => throw new NotImplementedException();

    public DbSet<Schedule> Schedules => throw new NotImplementedException();

    public DbSet<SessionLess> SessionLesses => throw new NotImplementedException();

    public DbSet<Spin> Spins => throw new NotImplementedException();

    public DbSet<SysLog> SysLogs => throw new NotImplementedException();

    public DbSet<TraderOnline> TraderOnlines => throw new NotImplementedException();

    public DbSet<Trading> Tradings => throw new NotImplementedException();

    public DbSet<TradingFast3> TradingFast3s => throw new NotImplementedException();

    public DbSet<TradingKeno> TradingKenos => throw new NotImplementedException();

    public DbSet<TradingLadder> TradingLadders => throw new NotImplementedException();

    public DbSet<TradingLuckyDerby> TradingLuckyDerbies => throw new NotImplementedException();

    public DbSet<TradingPayout> TradingPayouts => throw new NotImplementedException();

    public DbSet<TradingPayoutFast3> TradingPayoutFast3s => throw new NotImplementedException();

    public DbSet<TradingPayoutKeno> TradingPayoutKenos => throw new NotImplementedException();

    public DbSet<TradingPayoutLadder> TradingPayoutLadders => throw new NotImplementedException();

    public DbSet<TradingPayoutLuckyDerby> TradingPayoutLuckyDerbies => throw new NotImplementedException();

    public DbSet<TradingPayoutPk10> TradingPayoutPk10s => throw new NotImplementedException();

    public DbSet<TradingPayoutRp> TradingPayoutRps => throw new NotImplementedException();

    public DbSet<TradingPayoutThaiLottery> TradingPayoutThaiLotteries => throw new NotImplementedException();

    public DbSet<TradingPayoutVnlottery> TradingPayoutVnlotteries => throw new NotImplementedException();

    public DbSet<TradingPayoutWukong> TradingPayoutWukongs => throw new NotImplementedException();

    public DbSet<TradingPk10> TradingPk10s => throw new NotImplementedException();

    public DbSet<TradingRp> TradingRps => throw new NotImplementedException();

    public DbSet<TradingThaiLottery> TradingThaiLotteries => throw new NotImplementedException();

    public DbSet<TradingVnlottery> TradingVnlotteries => throw new NotImplementedException();

    public DbSet<TradingWukong> TradingWukongs => throw new NotImplementedException();

    public DbSet<TrialPromotion> TrialPromotions => throw new NotImplementedException();

    public DbSet<TrialPromotionCurrency> TrialPromotionCurrencies => throw new NotImplementedException();

    public DbSet<TrialPromotionGame> TrialPromotionGames => throw new NotImplementedException();

    public DbSet<TrialPromotionMember> TrialPromotionMembers => throw new NotImplementedException();

    public DbSet<TrialPromotionMemberTransaction> TrialPromotionMemberTransactions => throw new NotImplementedException();

    public DbSet<VAdminRoleProduct> VAdminRoleProducts => throw new NotImplementedException();

    public DbSet<VB> VBs => throw new NotImplementedException();

    public DbSet<VBfast3> VBfast3s => throw new NotImplementedException();

    public DbSet<VBiLotto> VBiLottos => throw new NotImplementedException();

    public DbSet<VBkeno> VBkenos => throw new NotImplementedException();

    public DbSet<VBladder> VBladders => throw new NotImplementedException();

    public DbSet<VBluckyDerby> VBluckyDerbies => throw new NotImplementedException();

    public DbSet<VBp> VBps => throw new NotImplementedException();

    public DbSet<VBp45day> VBp45days => throw new NotImplementedException();

    public DbSet<VBpfast3> VBpfast3s => throw new NotImplementedException();

    public DbSet<VBpfast345Day> VBpfast345Days => throw new NotImplementedException();

    public DbSet<VBpiLotto> VBpiLottos => throw new NotImplementedException();

    public DbSet<VBpiLotto45Day> VBpiLotto45Days => throw new NotImplementedException();

    public DbSet<VBpk10> VBpk10s => throw new NotImplementedException();

    public DbSet<VBpkeno> VBpkenos => throw new NotImplementedException();

    public DbSet<VBpkeno45Day> VBpkeno45Days => throw new NotImplementedException();

    public DbSet<VBpladder> VBpladders => throw new NotImplementedException();

    public DbSet<VBpladder45Day> VBpladder45Days => throw new NotImplementedException();

    public DbSet<VBpluckyDerby> VBpluckyDerbies => throw new NotImplementedException();

    public DbSet<VBpluckyDerby45Day> VBpluckyDerby45Days => throw new NotImplementedException();

    public DbSet<VBppk10> VBppk10s => throw new NotImplementedException();

    public DbSet<VBppk1045day> VBppk1045days => throw new NotImplementedException();

    public DbSet<VBprp> VBprps => throw new NotImplementedException();

    public DbSet<VBprps45day> VBprps45days => throw new NotImplementedException();

    public DbSet<VBpthaiLottery> VBpthaiLotteries => throw new NotImplementedException();

    public DbSet<VBpthaiLottery45Day> VBpthaiLottery45Days => throw new NotImplementedException();

    public DbSet<VBpvnlottery> VBpvnlotteries => throw new NotImplementedException();

    public DbSet<VBpvnlottery45Day> VBpvnlottery45Days => throw new NotImplementedException();

    public DbSet<VBpwukong> VBpwukongs => throw new NotImplementedException();

    public DbSet<VBpwukong45Day> VBpwukong45Days => throw new NotImplementedException();

    public DbSet<VBrp> VBrps => throw new NotImplementedException();

    public DbSet<VBthaiLottery> VBthaiLotteries => throw new NotImplementedException();

    public DbSet<VBvnlottery> VBvnlotteries => throw new NotImplementedException();

    public DbSet<VBwukong> VBwukongs => throw new NotImplementedException();

    public DbSet<VCurrency> VCurrencies => throw new NotImplementedException();

    public DbSet<VDraw> VDraws => throw new NotImplementedException();

    public DbSet<VMember> VMembers => throw new NotImplementedException();

    public DbSet<VProductBetConfig> VProductBetConfigs => throw new NotImplementedException();

    public DbSet<VProductConfigType> VProductConfigTypes => throw new NotImplementedException();

    public DbSet<VendorConfig> VendorConfigs => throw new NotImplementedException();

    public DbSet<VendorConfigSideMenuSetting> VendorConfigSideMenuSettings => throw new NotImplementedException();

    public DbSet<VendorCurrency> VendorCurrencies => throw new NotImplementedException();

    public DbSet<VendorDomainBo> VendorDomainBos => throw new NotImplementedException();

    public DbSet<VendorDomainBowhitelist> VendorDomainBowhitelists => throw new NotImplementedException();

    public DbSet<VendorDomainFe> VendorDomainves => throw new NotImplementedException();

    public DbSet<VendorLimitGroup> VendorLimitGroups => throw new NotImplementedException();

    public DbSet<VendorLimitProfile> VendorLimitProfiles => throw new NotImplementedException();

    public DbSet<VendorLimitProfileSetting> VendorLimitProfileSettings => throw new NotImplementedException();

    public DbSet<VendorWalletConfig> VendorWalletConfigs => throw new NotImplementedException();

    public DbSet<VendorWalletProductConfig> VendorWalletProductConfigs => throw new NotImplementedException();

    public DbSet<WalletProduct> WalletProducts => throw new NotImplementedException();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _mediator.DispatchDomainEvents(this);

        return await base.SaveChangesAsync(cancellationToken);
    }

    public IQueryable<TResult> SqlQueryRaw<TResult>([NotParameterized] string sql, params object[] parameters)
    {
        return this.SqlQueryRaw<TResult>(sql, parameters);
    }
}
