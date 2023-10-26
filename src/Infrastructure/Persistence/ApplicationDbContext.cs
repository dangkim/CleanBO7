using System;
using System.Collections.Generic;
using CleanBO7.Infrastructure.Identity;
using CleanBO7.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using CleanBO7.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using CleanBO7.Infrastructure.Persistence.Interceptors;
using MediatR;

namespace CleanBO7.Infrastructure.Persistence;

public partial class ApplicationDbContext : DbContext, IApplicationDbContext
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

    //public DbSet<TodoList> TodoLists => Set<TodoList>();

    //public DbSet<Product> Products => Set<Product>();

    public DbSet<Admin> Admins => Set<Admin>();

    public DbSet<AdminForce> AdminForces => Set<AdminForce>();

    public DbSet<AdminLevel> AdminLevels => Set<AdminLevel>();

    public DbSet<AdminRole> AdminRoles => Set<AdminRole>();

    public DbSet<AdminRoleProduct> AdminRoleProducts => Set<AdminRoleProduct>();

    public DbSet<Bet> Bets => Set<Bet>();

    public DbSet<BetBundle> BetBundles => Set<BetBundle>();

    public DbSet<BetsFast3> BetsFast3s => Set<BetsFast3>();

    public DbSet<BetsKeno> BetsKenos => Set<BetsKeno>();

    public DbSet<BetsLadder> BetsLadders => Set<BetsLadder>();

    public DbSet<BetsLuckyDerby> BetsLuckyDerbies => Set<BetsLuckyDerby>();

    public DbSet<BetsPayout> BetsPayouts => Set<BetsPayout>();

    public DbSet<BetsPayoutFast3> BetsPayoutFast3s => Set<BetsPayoutFast3>();

    public DbSet<BetsPayoutKeno> BetsPayoutKenos => Set<BetsPayoutKeno>();

    public DbSet<BetsPayoutLadder> BetsPayoutLadders => Set<BetsPayoutLadder>();

    public DbSet<BetsPayoutLuckyDerby> BetsPayoutLuckyDerbies => Set<BetsPayoutLuckyDerby>();

    public DbSet<BetsPayoutPk10> BetsPayoutPk10s => Set<BetsPayoutPk10>();

    public DbSet<BetsPayoutRp> BetsPayoutRps => Set<BetsPayoutRp>();

    public DbSet<BetsPayoutThaiLottery> BetsPayoutThaiLotteries => Set<BetsPayoutThaiLottery>();

    public DbSet<BetsPayoutVnlottery> BetsPayoutVnlotteries => Set<BetsPayoutVnlottery>();

    public DbSet<BetsPayoutWukong> BetsPayoutWukongs => Set<BetsPayoutWukong>();

    public DbSet<BetsPk10> BetsPk10s => Set<BetsPk10>();

    public DbSet<BetsRp> BetsRps => Set<BetsRp>();

    public DbSet<BetsThaiLottery> BetsThaiLotteries => Set<BetsThaiLottery>();

    public DbSet<BetsVnlottery> BetsVnlotteries => Set<BetsVnlottery>();

    public DbSet<BetsWukong> BetsWukongs => Set<BetsWukong>();

    public DbSet<CurrenciesRateDetail> CurrenciesRateDetails => Set<CurrenciesRateDetail>();

    public DbSet<Currency> Currencies => Set<Currency>();

    public DbSet<CustomWalletRound> CustomWalletRounds => Set<CustomWalletRound>();

    public DbSet<Dict> Dicts => Set<Dict>();

    public DbSet<DigitRiskBalancer> DigitRiskBalancers => Set<DigitRiskBalancer>();

    public DbSet<Draw> Draws => Set<Draw>();

    public DbSet<DrawMemberAction> DrawMemberActions => Set<DrawMemberAction>();

    public DbSet<DrawSummary> DrawSummaries => Set<DrawSummary>();

    public DbSet<DrawSummaryDetail> DrawSummaryDetails => Set<DrawSummaryDetail>();

    public DbSet<DrawsDetail> DrawsDetails => Set<DrawsDetail>();

    public DbSet<DrawsTrend> DrawsTrends => Set<DrawsTrend>();

    public DbSet<DynamicOdd> DynamicOdds => Set<DynamicOdd>();

    public DbSet<GameBet> GameBets => Set<GameBet>();

    public DbSet<GameBetBundle> GameBetBundles => Set<GameBetBundle>();

    public DbSet<GeneralSetting> GeneralSettings => Set<GeneralSetting>();

    public DbSet<Language> Languages => Set<Language>();

    public DbSet<LimitHistory> LimitHistories => Set<LimitHistory>();

    public DbSet<LotteryJob> LotteryJobs => Set<LotteryJob>();

    public DbSet<Member> Members => Set<Member>();

    public DbSet<MemberBetProfile> MemberBetProfiles => Set<MemberBetProfile>();

    public DbSet<MemberDetail> MemberDetails => Set<MemberDetail>();

    public DbSet<MemberIp> MemberIps => Set<MemberIp>();

    public DbSet<MemberLimit> MemberLimits => Set<MemberLimit>();

    public DbSet<MemberLimitProfile> MemberLimitProfiles => Set<MemberLimitProfile>();

    public DbSet<MemberLimitProfileSetting> MemberLimitProfileSettings => Set<MemberLimitProfileSetting>();

    public DbSet<Notice> Notices => Set<Notice>();

    public DbSet<Product> Products => Set<Product>();

    public DbSet<ProductAreaConfig> ProductAreaConfigs => Set<ProductAreaConfig>();

    public DbSet<ProductAreaConfigRule> ProductAreaConfigRules => Set<ProductAreaConfigRule>();

    public DbSet<ProductBetConfig> ProductBetConfigs => Set<ProductBetConfig>();

    public DbSet<ProductBetConfigParlay> ProductBetConfigParlays => Set<ProductBetConfigParlay>();

    public DbSet<ProductBetConfigParlaySetting> ProductBetConfigParlaySettings => Set<ProductBetConfigParlaySetting>();

    public DbSet<ProductBetType> ProductBetTypes => Set<ProductBetType>();

    public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();

    public DbSet<ProductCategoryConfig> ProductCategoryConfigs => Set<ProductCategoryConfig>();

    public DbSet<ProductLimit> ProductLimits => Set<ProductLimit>();

    public DbSet<ProductLimitDetail> ProductLimitDetails => Set<ProductLimitDetail>();

    public DbSet<ProductLimitGroup> ProductLimitGroups => Set<ProductLimitGroup>();

    public DbSet<ProductOdd> ProductOdds => Set<ProductOdd>();

    public DbSet<ProductRestriction> ProductRestrictions => Set<ProductRestriction>();

    public DbSet<ProductSetting> ProductSettings => Set<ProductSetting>();

    public DbSet<ProductTicketRestriction> ProductTicketRestrictions => Set<ProductTicketRestriction>();

    public DbSet<ProviderBrand> ProviderBrands => Set<ProviderBrand>();

    public DbSet<ProviderBrandDomain> ProviderBrandDomains => Set<ProviderBrandDomain>();

    public DbSet<Restriction> Restrictions => Set<Restriction>();

    public DbSet<RiskBalancerTracking> RiskBalancerTrackings => Set<RiskBalancerTracking>();

    public DbSet<Rtp> Rtps => Set<Rtp>();

    public DbSet<Schedule> Schedules => Set<Schedule>();

    public DbSet<SessionLess> SessionLesses => Set<SessionLess>();

    public DbSet<Spin> Spins => Set<Spin>();

    public DbSet<SysLog> SysLogs => Set<SysLog>();

    public DbSet<TraderOnline> TraderOnlines => Set<TraderOnline>();

    public DbSet<Trading> Tradings => Set<Trading>();

    public DbSet<TradingFast3> TradingFast3s => Set<TradingFast3>();

    public DbSet<TradingKeno> TradingKenos => Set<TradingKeno>();

    public DbSet<TradingLadder> TradingLadders => Set<TradingLadder>();

    public DbSet<TradingLuckyDerby> TradingLuckyDerbies => Set<TradingLuckyDerby>();

    public DbSet<TradingPayout> TradingPayouts => Set<TradingPayout>();

    public DbSet<TradingPayoutFast3> TradingPayoutFast3s => Set<TradingPayoutFast3>();

    public DbSet<TradingPayoutKeno> TradingPayoutKenos => Set<TradingPayoutKeno>();

    public DbSet<TradingPayoutLadder> TradingPayoutLadders => Set<TradingPayoutLadder>();

    public DbSet<TradingPayoutLuckyDerby> TradingPayoutLuckyDerbies => Set<TradingPayoutLuckyDerby>();

    public DbSet<TradingPayoutPk10> TradingPayoutPk10s => Set<TradingPayoutPk10>();

    public DbSet<TradingPayoutRp> TradingPayoutRps => Set<TradingPayoutRp>();

    public DbSet<TradingPayoutThaiLottery> TradingPayoutThaiLotteries => Set<TradingPayoutThaiLottery>();

    public DbSet<TradingPayoutVnlottery> TradingPayoutVnlotteries => Set<TradingPayoutVnlottery>();

    public DbSet<TradingPayoutWukong> TradingPayoutWukongs => Set<TradingPayoutWukong>();

    public DbSet<TradingPk10> TradingPk10s => Set<TradingPk10>();

    public DbSet<TradingRp> TradingRps => Set<TradingRp>();

    public DbSet<TradingThaiLottery> TradingThaiLotteries => Set<TradingThaiLottery>();

    public DbSet<TradingVnlottery> TradingVnlotteries => Set<TradingVnlottery>();

    public DbSet<TradingWukong> TradingWukongs => Set<TradingWukong>();

    public DbSet<TrialPromotion> TrialPromotions => Set<TrialPromotion>();

    public DbSet<TrialPromotionCurrency> TrialPromotionCurrencies => Set<TrialPromotionCurrency>();

    public DbSet<TrialPromotionGame> TrialPromotionGames => Set<TrialPromotionGame>();

    public DbSet<TrialPromotionMember> TrialPromotionMembers => Set<TrialPromotionMember>();

    public DbSet<TrialPromotionMemberTransaction> TrialPromotionMemberTransactions => Set<TrialPromotionMemberTransaction>();

    public DbSet<VAdminRoleProduct> VAdminRoleProducts => Set<VAdminRoleProduct>();

    public DbSet<VB> VBs => Set<VB>();

    public DbSet<VBfast3> VBfast3s => Set<VBfast3>();

    public DbSet<VBiLotto> VBiLottos => Set<VBiLotto>();

    public DbSet<VBkeno> VBkenos => Set<VBkeno>();

    public DbSet<VBladder> VBladders => Set<VBladder>();

    public DbSet<VBluckyDerby> VBluckyDerbies => Set<VBluckyDerby>();

    public DbSet<VBp> VBps => Set<VBp>();

    public DbSet<VBp45day> VBp45days => Set<VBp45day>();

    public DbSet<VBpfast3> VBpfast3s => Set<VBpfast3>();

    public DbSet<VBpfast345Day> VBpfast345Days => Set<VBpfast345Day>();

    public DbSet<VBpiLotto> VBpiLottos => Set<VBpiLotto>();

    public DbSet<VBpiLotto45Day> VBpiLotto45Days => Set<VBpiLotto45Day>();

    public DbSet<VBpk10> VBpk10s => Set<VBpk10>();

    public DbSet<VBpkeno> VBpkenos => Set<VBpkeno>();

    public DbSet<VBpkeno45Day> VBpkeno45Days => Set<VBpkeno45Day>();

    public DbSet<VBpladder> VBpladders => Set<VBpladder>();

    public DbSet<VBpladder45Day> VBpladder45Days => Set<VBpladder45Day>();

    public DbSet<VBpluckyDerby> VBpluckyDerbies => Set<VBpluckyDerby>();

    public DbSet<VBpluckyDerby45Day> VBpluckyDerby45Days => Set<VBpluckyDerby45Day>();

    public DbSet<VBppk10> VBppk10s => Set<VBppk10>();

    public DbSet<VBppk1045day> VBppk1045days => Set<VBppk1045day>();

    public DbSet<VBprp> VBprps => Set<VBprp>();

    public DbSet<VBprps45day> VBprps45days => Set<VBprps45day>();

    public DbSet<VBpthaiLottery> VBpthaiLotteries => Set<VBpthaiLottery>();

    public DbSet<VBpthaiLottery45Day> VBpthaiLottery45Days => Set<VBpthaiLottery45Day>();

    public DbSet<VBpvnlottery> VBpvnlotteries => Set<VBpvnlottery>();

    public DbSet<VBpvnlottery45Day> VBpvnlottery45Days => Set<VBpvnlottery45Day>();

    public DbSet<VBpwukong> VBpwukongs => Set<VBpwukong>();

    public DbSet<VBpwukong45Day> VBpwukong45Days => Set<VBpwukong45Day>();

    public DbSet<VBrp> VBrps => Set<VBrp>();

    public DbSet<VBthaiLottery> VBthaiLotteries => Set<VBthaiLottery>();

    public DbSet<VBvnlottery> VBvnlotteries => Set<VBvnlottery>();

    public DbSet<VBwukong> VBwukongs => Set<VBwukong>();

    public DbSet<VCurrency> VCurrencies => Set<VCurrency>();

    public DbSet<VDraw> VDraws => Set<VDraw>();

    public DbSet<VMember> VMembers => Set<VMember>();

    public DbSet<VProductBetConfig> VProductBetConfigs => Set<VProductBetConfig>();

    public DbSet<VProductConfigType> VProductConfigTypes => Set<VProductConfigType>();

    public DbSet<VendorConfig> VendorConfigs => Set<VendorConfig>();

    public DbSet<VendorConfigSideMenuSetting> VendorConfigSideMenuSettings => Set<VendorConfigSideMenuSetting>();

    public DbSet<VendorCurrency> VendorCurrencies => Set<VendorCurrency>();

    public DbSet<VendorDomainBo> VendorDomainBos => Set<VendorDomainBo>();

    public DbSet<VendorDomainBowhitelist> VendorDomainBowhitelists => Set<VendorDomainBowhitelist>();

    public DbSet<VendorDomainFe> VendorDomainves => Set<VendorDomainFe>();

    public DbSet<VendorLimitGroup> VendorLimitGroups => Set<VendorLimitGroup>();

    public DbSet<VendorLimitProfile> VendorLimitProfiles => Set<VendorLimitProfile>();

    public DbSet<VendorLimitProfileSetting> VendorLimitProfileSettings => Set<VendorLimitProfileSetting>();

    public DbSet<VendorWalletConfig> VendorWalletConfigs => Set<VendorWalletConfig>();

    public DbSet<VendorWalletProductConfig> VendorWalletProductConfigs => Set<VendorWalletProductConfig>();

    public DbSet<WalletProduct> WalletProducts => Set<WalletProduct>();

    public IQueryable<TResult> SqlQueryRaw<TResult>([NotParameterized] string sql, params object[] parameters)
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("Admin");

            entity.Property(e => e.AdminId).HasColumnName("adminID");
            entity.Property(e => e.AdminActivation)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("adminActivation");
            entity.Property(e => e.AdminDefault)
                .HasDefaultValueSql("((0))")
                .HasColumnName("adminDefault");
            entity.Property(e => e.AdminDefaultProduct).HasColumnName("adminDefaultProduct");
            entity.Property(e => e.AdminForceAttempt).HasColumnName("adminForceAttempt");
            entity.Property(e => e.AdminLoginIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adminLoginIP");
            entity.Property(e => e.AdminLoginTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adminLoginTime");
            entity.Property(e => e.AdminLogoutTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adminLogoutTime");
            entity.Property(e => e.AdminMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adminMail");
            entity.Property(e => e.AdminPassword)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("adminPassword");
            entity.Property(e => e.AdminRealName)
                .HasMaxLength(50)
                .HasColumnName("adminRealName");
            entity.Property(e => e.AdminRegTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adminRegTime");
            entity.Property(e => e.AdminRole).HasColumnName("adminRole");
            entity.Property(e => e.AdminStatus).HasColumnName("adminStatus");
            entity.Property(e => e.AdminSuperior).HasColumnName("adminSuperior");
            entity.Property(e => e.AdminUpdateTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adminUpdateTime");
            entity.Property(e => e.AdminUsername)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("adminUsername");
            entity.Property(e => e.AdminVendorId).HasColumnName("adminVendorID");
            entity.Property(e => e.IsCas).HasColumnName("isCas");
        });

        modelBuilder.Entity<AdminForce>(entity =>
        {
            entity.HasKey(e => e.ForceId);

            entity.ToTable("AdminForce");

            entity.Property(e => e.ForceId).HasColumnName("forceId");
            entity.Property(e => e.ForceActionTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("forceActionTime");
            entity.Property(e => e.ForceCount).HasColumnName("forceCount");
            entity.Property(e => e.ForceIpaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("forceIPAddress");
            entity.Property(e => e.ForceMacAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("forceMacAddress");
        });

        modelBuilder.Entity<AdminLevel>(entity =>
        {
            entity.HasKey(e => e.LevelId);

            entity.ToTable("AdminLevel");

            entity.Property(e => e.LevelId).HasColumnName("levelID");
            entity.Property(e => e.LevelExplain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("levelExplain");
            entity.Property(e => e.LevelName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("levelName");
            entity.Property(e => e.LevelNo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("levelNo");
            entity.Property(e => e.LevelPath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("levelPath");
            entity.Property(e => e.LevelSetTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("levelSetTime");
            entity.Property(e => e.LevelVendorId)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("levelVendorID");
        });

        modelBuilder.Entity<AdminRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("AdminRole");

            entity.Property(e => e.RoleId).HasColumnName("roleID");
            entity.Property(e => e.RoleDefault).HasColumnName("roleDefault");
            entity.Property(e => e.RoleLevel).IsUnicode(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("roleName");
            entity.Property(e => e.RoleParentId).HasColumnName("roleParentID");
            entity.Property(e => e.RoleSetTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("roleSetTime");
            entity.Property(e => e.RoleStatus).HasColumnName("roleStatus");
            entity.Property(e => e.RoleTrader).HasColumnName("roleTrader");
            entity.Property(e => e.RoleUpdateTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("roleUpdateTime");
            entity.Property(e => e.RoleVendorId).HasColumnName("roleVendorID");
        });

        modelBuilder.Entity<AdminRoleProduct>(entity =>
        {
            entity.HasKey(e => e.RoleProductId);

            entity.ToTable("AdminRoleProduct");

            entity.Property(e => e.RoleProductId).HasColumnName("roleProductId");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.RoleId).HasColumnName("roleID");
            entity.Property(e => e.RoleLevel)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("roleLevel");
        });

        modelBuilder.Entity<Bet>(entity =>
        {
            entity.HasKey(e => e.BetNo).HasName("PK__Bets__23013545B1F44FB2");

            entity.HasIndex(e => new { e.DrawId, e.BetStatus, e.MemberType }, "IX_Bets_1").HasFillFactor(90);

            entity.HasIndex(e => e.BetId, "IX_Bets_2");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.HasIndex(e => new { e.DrawId, e.BetStatus, e.BetUpdateStatus }, "ix_Bets_3").HasFillFactor(90);

            entity.HasIndex(e => new { e.DrawId, e.BetTypeUid, e.BetStatus, e.BetUpdateStatus }, "ix_Bets_4").HasFillFactor(90);

            entity.HasIndex(e => e.MemberUid, "ix_Bets_5").HasFillFactor(90);

            entity.Property(e => e.BetNo)
                .ValueGeneratedNever()
                .HasColumnName("betNo");
            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount).HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetBundle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetBundle");

            entity.HasIndex(e => e.Id, "UQ__BetBundl__3214EC06C4A1B718").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BetsFast3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsFast3");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsKeno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsKeno");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsLadder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsLadder");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsLuckyDerby>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsLuckyDerby");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayout>(entity =>
        {
            entity.HasKey(e => e.BetNo);

            entity.ToTable("BetsPayout");

            entity.HasIndex(e => new { e.DrawId, e.MemberType, e.BetStatus, e.BetUpdateStatus, e.BetTypeUid }, "IX_BetsPayout_1").HasFillFactor(90);

            entity.HasIndex(e => e.BetId, "IX_BetsPayout_2").HasFillFactor(90);

            entity.HasIndex(e => new { e.BetTypeUid, e.DrawId, e.MemberType }, "IX_BetsPayout_3").HasFillFactor(90);

            entity.HasIndex(e => new { e.MemberUid, e.BetStatus, e.DrawId }, "IX_BetsPayout_4").HasFillFactor(90);

            entity.HasIndex(e => e.MemberUid, "IX_BetsPayout_5").HasFillFactor(90);

            entity.HasIndex(e => new { e.MemberUid, e.BetStatus, e.DrawId }, "ix_BetsPayout_6").HasFillFactor(90);

            entity.Property(e => e.BetNo)
                .ValueGeneratedNever()
                .HasColumnName("betNo");
            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount).HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutFast3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutFast3");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutKeno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutKeno");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutLadder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutLadder");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutLuckyDerby>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutLuckyDerby");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutPk10>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutPK10");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutRp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutRPS");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutThaiLottery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutThaiLottery");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutVnlottery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutVNLottery");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPayoutWukong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPayoutWukong");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsPk10>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsPK10");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsRp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsRPS");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsThaiLottery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsThaiLottery");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsVnlottery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsVNLottery");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<BetsWukong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BetsWukong");

            entity.HasIndex(e => e.BetBundleId, "IX_Bets_6");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.ActualBetTime)
                .HasColumnType("datetime")
                .HasColumnName("actualBetTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.ArchiveDate)
                .HasColumnType("datetime")
                .HasColumnName("archiveDate");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ReportRefNo).HasColumnName("reportRefNo");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.TimeBet)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<CurrenciesRateDetail>(entity =>
        {
            entity.ToTable("CurrenciesRateDetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrencyId).HasColumnName("currencyId");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.LastUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateTime");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.Property(e => e.CurrencyId)
                .ValueGeneratedOnAdd()
                .HasColumnName("currencyId");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
        });

        modelBuilder.Entity<CustomWalletRound>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomWalletRound");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Dict>(entity =>
        {
            entity.ToTable("Dict");

            entity.Property(e => e.DictId).HasColumnName("dictID");
            entity.Property(e => e.DictColumn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dictColumn");
            entity.Property(e => e.DictExplain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dictExplain");
            entity.Property(e => e.DictNo).HasColumnName("dictNo");
        });

        modelBuilder.Entity<DigitRiskBalancer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DigitRis__3213E83FDADF4BF9");

            entity.ToTable("DigitRiskBalancer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.Config)
                .IsUnicode(false)
                .HasColumnName("config");
            entity.Property(e => e.ProductId).HasColumnName("productId");
        });

        modelBuilder.Entity<Draw>(entity =>
        {
            entity.HasIndex(e => new { e.DrawId, e.ProductId }, "NonClusteredIndex-20190806-101912");

            entity.HasIndex(e => e.DrawNo, "NonClusteredIndex-20190806-102508");

            entity.HasIndex(e => new { e.DrawId, e.ProductId, e.AreaId, e.DrawNo, e.StartTime, e.EndTime }, "ix_Draws_2");

            entity.HasIndex(e => new { e.ProductId, e.AreaId, e.DrawNo }, "ix_Draws_3");

            entity.HasIndex(e => new { e.ProductId, e.AreaId, e.StartTime, e.EndTime }, "ix_Draws_4");

            entity.HasIndex(e => new { e.ProductId, e.AreaId, e.StartTime, e.EndTime }, "ix_Draws_6");

            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.CancelBetTime).HasColumnName("cancelBetTime");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createTime");
            entity.Property(e => e.DrawNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("drawNo");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("endTime");
            entity.Property(e => e.ExtraData).IsUnicode(false);
            entity.Property(e => e.Internaldata)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("startTime");
            entity.Property(e => e.TimeZone).HasColumnName("timeZone");
            entity.Property(e => e.TrendValue)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DrawMemberAction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DrawMemberAction");

            entity.HasIndex(e => new { e.DrawId, e.MemberUid, e.ActionId }, "DF_DrawMemberAction_Unique").IsUnique();

            entity.HasIndex(e => new { e.DrawId, e.MemberUid }, "IX_DrawMemberAction_1").IsDescending();

            entity.Property(e => e.Content)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Steps)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DrawSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DrawSummary");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DateConsolidated).HasColumnType("datetime");
            entity.Property(e => e.DrawNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DrawSummaryDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DrawSummaryDetail");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PlatformOs).HasColumnName("PlatformOS");
        });

        modelBuilder.Entity<DrawsDetail>(entity =>
        {
            entity.HasKey(e => e.DetailAutoId).HasName("pk_DrawsDetail");

            entity.ToTable("DrawsDetail");

            entity.HasIndex(e => new { e.DrawId, e.Status }, "NonClusteredIndex-20190806-102557");

            entity.HasIndex(e => e.StatusCredit, "NonClusteredIndex-20190806-102730");

            entity.HasIndex(e => e.Status, "ix_DrawsDetail_2");

            entity.Property(e => e.DetailAutoId).HasColumnName("detailAutoID");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("deviceId");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsConfirmTime).HasColumnType("datetime");
            entity.Property(e => e.IsConfirmTimeCredit).HasColumnType("datetime");
            entity.Property(e => e.IsManualTime).HasColumnType("datetime");
            entity.Property(e => e.IsPayoutTime).HasColumnType("datetime");
            entity.Property(e => e.IsPayoutTimeCredit).HasColumnType("datetime");
            entity.Property(e => e.IsUnprocessTime).HasColumnType("datetime");
            entity.Property(e => e.IsUnprocessTimeCredit).HasColumnType("datetime");
            entity.Property(e => e.LiveBet)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("liveBet");
            entity.Property(e => e.MoreBet)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("moreBet");
            entity.Property(e => e.Pass).HasColumnName("pass");
            entity.Property(e => e.PassRemark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passRemark");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.RemarkCredit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("remarkCredit");
            entity.Property(e => e.ResultNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("resultNo");
            entity.Property(e => e.ResultTime)
                .HasColumnType("datetime")
                .HasColumnName("resultTime");
            entity.Property(e => e.ResultTimeCredit)
                .HasColumnType("datetime")
                .HasColumnName("resultTimeCredit");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StatusCredit).HasColumnName("statusCredit");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateTimeCredit)
                .HasColumnType("datetime")
                .HasColumnName("updateTimeCredit");
        });

        modelBuilder.Entity<DrawsTrend>(entity =>
        {
            entity.HasKey(e => e.DrawId).HasName("pk_DrawsTrend");

            entity.ToTable("DrawsTrend");

            entity.Property(e => e.DrawId)
                .ValueGeneratedNever()
                .HasColumnName("drawId");
            entity.Property(e => e.Hotgap)
                .IsUnicode(false)
                .HasColumnName("hotgap");
            entity.Property(e => e.TrendKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("trendKey");
            entity.Property(e => e.TrendValue)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("trendValue");
        });

        modelBuilder.Entity<DynamicOdd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DynamicO__3213E83FC2B5AE36");

            entity.ToTable("DynamicOdd");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.Odds)
                .IsUnicode(false)
                .HasColumnName("odds");
        });

        modelBuilder.Entity<GameBet>(entity =>
        {
            entity.ToTable("GameBet");

            entity.HasIndex(e => new { e.DrawId, e.TypeId, e.Content }, "IX_GameBet_1").IsDescending(true, false, false);

            entity.HasIndex(e => e.BundleId, "IX_GameBet_2").IsDescending();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BundleId).HasColumnName("bundleId");
            entity.Property(e => e.Content)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.CurrencyId).HasColumnName("currencyId");
            entity.Property(e => e.DoneTime)
                .HasColumnType("datetime")
                .HasColumnName("doneTime");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PayoutAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("payoutAmount");
            entity.Property(e => e.Platform).HasColumnName("platform");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TypeId).HasColumnName("typeId");
        });

        modelBuilder.Entity<GameBetBundle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GameBetB__3214EC07B5F0AD00");

            entity.ToTable("GameBetBundle");

            entity.HasIndex(e => e.CreatedAt, "idx_GameBetBundle_CreateAt");

            entity.HasIndex(e => e.DrawId, "idx_GameBetBundle_DrawId");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<GeneralSetting>(entity =>
        {
            entity.HasKey(e => e.GeneralAutoId);

            entity.ToTable("GeneralSetting");

            entity.Property(e => e.GeneralAutoId).HasColumnName("generalAutoID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.GeneralKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("generalKey");
            entity.Property(e => e.GeneralValue)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("generalValue");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LangId);

            entity.Property(e => e.LangId).HasColumnName("langId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<LimitHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LimitHistory");

            entity.Property(e => e.Msg)
                .HasColumnType("text")
                .HasColumnName("msg");
            entity.Property(e => e.MsgTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("msgTime");
        });

        modelBuilder.Entity<LotteryJob>(entity =>
        {
            entity.HasKey(e => new { e.JobType, e.ProductId }).HasName("PK__LotteryJ__5BA9B0FF1202F982");

            entity.Property(e => e.JobId).ValueGeneratedOnAdd();
            entity.Property(e => e.Sql).IsUnicode(false);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberUid);

            entity.ToTable("Member");

            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.IsFun).HasColumnName("isFun");
            entity.Property(e => e.IsTest).HasColumnName("isTest");
            entity.Property(e => e.MWalletId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mWalletId");
            entity.Property(e => e.MemberId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberId");
            entity.Property(e => e.MemberType)
                .HasDefaultValueSql("((1))")
                .HasColumnName("memberType");
            entity.Property(e => e.RegTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("regTime");
            entity.Property(e => e.VendorId).HasColumnName("vendorId");
        });

        modelBuilder.Entity<MemberBetProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileUid).HasName("pk_MemberBetProfile");

            entity.ToTable("MemberBetProfile");

            entity.Property(e => e.ProfileUid).HasColumnName("profileUid");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.ProfileId).HasColumnName("profileId");
            entity.Property(e => e.Templates)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("templates");
            entity.Property(e => e.UpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");
        });

        modelBuilder.Entity<MemberDetail>(entity =>
        {
            entity.HasKey(e => e.DetailMemberUid).HasName("pk_MemberDetail");

            entity.ToTable("MemberDetail");

            entity.Property(e => e.DetailMemberUid)
                .ValueGeneratedNever()
                .HasColumnName("detailMemberUId");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.IsKick).HasColumnName("isKick");
            entity.Property(e => e.IsLock).HasColumnName("isLock");
            entity.Property(e => e.IsOnline).HasColumnName("isOnline");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.LastOnlineTime)
                .HasColumnType("datetime")
                .HasColumnName("lastOnlineTime");
            entity.Property(e => e.LoginCount).HasColumnName("loginCount");
            entity.Property(e => e.Logoff)
                .HasColumnType("datetime")
                .HasColumnName("logoff");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .HasColumnName("memberName");
            entity.Property(e => e.ReservedValue)
                .IsUnicode(false)
                .HasColumnName("reservedValue");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.TokenM)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokenM");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.Wallet)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("wallet");
        });

        modelBuilder.Entity<MemberIp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_MemberIP");

            entity.ToTable("MemberIP");

            entity.Property(e => e.Browser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("browser");
            entity.Property(e => e.BrowserLanguage)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("browserLanguage");
            entity.Property(e => e.BrowserVer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("browserVer");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.IsMobile).HasColumnName("isMobile");
            entity.Property(e => e.JavascriptSupport).HasColumnName("javascriptSupport");
            entity.Property(e => e.JavascriptVersion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("javascriptVersion");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("loginTime");
            entity.Property(e => e.LongIp).HasColumnName("longIP");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.MobileDeviceManufacturer)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("mobileDeviceManufacturer");
            entity.Property(e => e.MobileDeviceModel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("mobileDeviceModel");
            entity.Property(e => e.PcName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pcName");
            entity.Property(e => e.Platform)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("platform");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("userAgent");
        });

        modelBuilder.Entity<MemberLimit>(entity =>
        {
            entity.HasKey(e => e.LimitId).HasName("PK_MemberToken");

            entity.ToTable("MemberLimit");

            entity.Property(e => e.LimitId).HasColumnName("limitId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.LimitMemberUid).HasColumnName("limitMemberUid");
            entity.Property(e => e.LimitProductId).HasColumnName("limitProductId");
            entity.Property(e => e.LimitVendorId).HasColumnName("limitVendorId");
            entity.Property(e => e.PassCurrencyRestriction)
                .HasDefaultValueSql("((0))")
                .HasColumnName("passCurrencyRestriction");
            entity.Property(e => e.Profile).HasColumnName("profile");
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.SelectedLimit).HasColumnName("selectedLimit");
        });

        modelBuilder.Entity<MemberLimitProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("MemberLimitProfile");

            entity.Property(e => e.ProfileId).HasColumnName("profileId");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profileName");
            entity.Property(e => e.ProfileProductId).HasColumnName("profileProductId");
            entity.Property(e => e.ProfileVendorId).HasColumnName("profileVendorId");
        });

        modelBuilder.Entity<MemberLimitProfileSetting>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("MemberLimitProfileSetting");

            entity.Property(e => e.ConfigId).HasColumnName("configId");
            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.ProfileId).HasColumnName("profileId");
            entity.Property(e => e.StakeMax)
                .IsUnicode(false)
                .HasColumnName("stakeMax");
            entity.Property(e => e.StakeMin)
                .IsUnicode(false)
                .HasColumnName("stakeMin");
        });

        modelBuilder.Entity<Notice>(entity =>
        {
            entity.ToTable("Notice");

            entity.Property(e => e.NoticeId).HasColumnName("noticeId");
            entity.Property(e => e.NoticeAdminId).HasColumnName("noticeAdminId");
            entity.Property(e => e.NoticeContent)
                .HasMaxLength(500)
                .HasColumnName("noticeContent");
            entity.Property(e => e.NoticeGroupId).HasColumnName("noticeGroupId");
            entity.Property(e => e.NoticeLangId).HasColumnName("noticeLangId");
            entity.Property(e => e.NoticeProductId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("noticeProductId");
            entity.Property(e => e.NoticePubTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("noticePubTime");
            entity.Property(e => e.NoticeUpdateTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("noticeUpdateTime");
            entity.Property(e => e.NoticeValidTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("noticeValidTime");
            entity.Property(e => e.NoticeVendorId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("noticeVendorId");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__2D10D16A0B161E66");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("productId");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.BrandId).HasDefaultValueSql("((1))");
            entity.Property(e => e.CustomConfig).IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GameCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gameCode");
            entity.Property(e => e.ParamName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("productCode");
            entity.Property(e => e.ProductName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("productName");
        });

        modelBuilder.Entity<ProductAreaConfig>(entity =>
        {
            entity.HasKey(e => e.AreaUid);

            entity.ToTable("ProductAreaConfig");

            entity.Property(e => e.AreaUid).HasColumnName("areaUID");
            entity.Property(e => e.AreaCancelBetTime).HasColumnName("areaCancelBetTime");
            entity.Property(e => e.AreaDrawNoStyle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("areaDrawNoStyle");
            entity.Property(e => e.AreaFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("areaFormat");
            entity.Property(e => e.AreaFrequency).HasColumnName("areaFrequency");
            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.AreaName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("areaName");
            entity.Property(e => e.AreaNameAlias)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("areaNameAlias");
            entity.Property(e => e.AreaNameCn)
                .HasMaxLength(100)
                .HasColumnName("areaNameCN");
            entity.Property(e => e.AreaResult).HasColumnName("areaResult");
            entity.Property(e => e.AreaStatus).HasColumnName("areaStatus");
            entity.Property(e => e.AreaStopBetTime).HasColumnName("areaStopBetTime");
            entity.Property(e => e.AreaTimeZone).HasColumnName("areaTimeZone");
            entity.Property(e => e.AreaUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("areaUrl");
            entity.Property(e => e.Dealer).HasColumnName("dealer");
            entity.Property(e => e.DelayDuration).HasColumnName("delayDuration");
            entity.Property(e => e.DisplayOrder).HasColumnName("DisplayORder");
            entity.Property(e => e.IsRng).HasColumnName("isRNG");
            entity.Property(e => e.PartialResultTime).HasDefaultValueSql("((0))");
            entity.Property(e => e.PayoutBetCount).HasColumnName("payoutBetCount");
            entity.Property(e => e.PayoutDrawNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payoutDrawNo");
            entity.Property(e => e.PayoutFailedCount).HasColumnName("payoutFailedCount");
            entity.Property(e => e.PayoutSuccessCount).HasColumnName("payoutSuccessCount");
            entity.Property(e => e.ProductId).HasColumnName("productId");
        });

        modelBuilder.Entity<ProductAreaConfigRule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductAreaConfigRule");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.AddDayFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("addDayFormat");
            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.EndTime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("endTime");
            entity.Property(e => e.FrequencyOverride).HasColumnName("frequencyOverride");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Start)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("start");
            entity.Property(e => e.StartDay)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("startDay");
            entity.Property(e => e.StartNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("startNo");
            entity.Property(e => e.StartTime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("startTime");
            entity.Property(e => e.Style)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("style");
            entity.Property(e => e.Version)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("version");
        });

        modelBuilder.Entity<ProductBetConfig>(entity =>
        {
            entity.HasKey(e => e.ConfigId).HasName("pk_ProductBetConfig");

            entity.ToTable("ProductBetConfig");

            entity.Property(e => e.ConfigId).HasColumnName("configId");
            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.AutoBalance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("autoBalance");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.CanBet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("canBet");
            entity.Property(e => e.GlobalLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("globalLimit");
            entity.Property(e => e.MaxWinning)
                .IsUnicode(false)
                .HasColumnName("maxWinning");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.StakeMax)
                .IsUnicode(false)
                .HasColumnName("stakeMax");
            entity.Property(e => e.StakeMin)
                .IsUnicode(false)
                .HasColumnName("stakeMin");
            entity.Property(e => e.UserLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("userLimit");
            entity.Property(e => e.VendorId).HasColumnName("vendorId");
        });

        modelBuilder.Entity<ProductBetConfigParlay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductBetConfigParlay");

            entity.Property(e => e.ParlayAutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("parlayAutoID");
            entity.Property(e => e.ParlayMax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("parlayMax");
            entity.Property(e => e.ParlayMin)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("parlayMin");
            entity.Property(e => e.ParlayOdds)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("parlayOdds");
            entity.Property(e => e.ParlayProductId).HasColumnName("parlayProductID");
            entity.Property(e => e.ParlayVendorId).HasColumnName("parlayVendorID");
        });

        modelBuilder.Entity<ProductBetConfigParlaySetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductBetConfigParlaySetting");

            entity.Property(e => e.ParlayAutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("parlayAutoID");
            entity.Property(e => e.ParlayCreateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("parlayCreateTime");
            entity.Property(e => e.ParlayOddsCoefficient)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("parlayOddsCoefficient");
            entity.Property(e => e.ParlayPayoutConfirm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("parlayPayoutConfirm");
            entity.Property(e => e.ParlayProductId).HasColumnName("parlayProductID");
            entity.Property(e => e.ParlayUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("parlayUpdateTime");
            entity.Property(e => e.ParlayVendorId).HasColumnName("parlayVendorID");
        });

        modelBuilder.Entity<ProductBetType>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.BetTypeUid }).HasName("pk_ProductBetTypes");

            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.Groupname)
                .HasMaxLength(50)
                .HasColumnName("groupname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Parlay).HasColumnName("parlay");
            entity.Property(e => e.RelatedId).HasColumnName("relatedID");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__ProductC__19093A0B7052F672");

            entity.ToTable("ProductCategory");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tag)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProductCategoryConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductC__3214EC07FF6778CA");

            entity.ToTable("ProductCategoryConfig");

            entity.HasOne(d => d.Category).WithMany(p => p.ProductCategoryConfigs)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_CategoryId");
        });

        modelBuilder.Entity<ProductLimit>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.ProductId, e.BetTypeUid });

            entity.ToTable("ProductLimit");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.IsSet).HasColumnName("isSet");
            entity.Property(e => e.SettingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("settingId");
        });

        modelBuilder.Entity<ProductLimitDetail>(entity =>
        {
            entity.HasKey(e => new { e.SettingId, e.CurrencyCode });

            entity.ToTable("ProductLimitDetail");

            entity.Property(e => e.SettingId).HasColumnName("settingId");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("currencyCode");
            entity.Property(e => e.DetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("detailId");
            entity.Property(e => e.Limit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("limit");
        });

        modelBuilder.Entity<ProductLimitGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("ProductLimitGroup");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
        });

        modelBuilder.Entity<ProductOdd>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Index, "UQ__ProductO__9A5B622918D1C750").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Odds).IsUnicode(false);
        });

        modelBuilder.Entity<ProductRestriction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductRestriction");

            entity.Property(e => e.RestrictionCurrencyId).HasColumnName("restrictionCurrencyId");
            entity.Property(e => e.RestrictionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("restrictionID");
            entity.Property(e => e.RestrictionProductId).HasColumnName("restrictionProductID");
            entity.Property(e => e.RestrictionVendorId).HasColumnName("restrictionVendorID");
        });

        modelBuilder.Entity<ProductSetting>(entity =>
        {
            entity.HasKey(e => e.SettingId);

            entity.ToTable("ProductSetting");

            entity.Property(e => e.SettingId).HasColumnName("settingId");
            entity.Property(e => e.LimitId).HasColumnName("limitId");
            entity.Property(e => e.Multiplier)
                .IsUnicode(false)
                .HasColumnName("multiplier");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Timeout).HasColumnName("timeout");
        });

        modelBuilder.Entity<ProductTicketRestriction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductTicketRestriction");

            entity.Property(e => e.RestrictionTicketNo).HasColumnName("restrictionTicketNo");
            entity.Property(e => e.TicketId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ticketID");
            entity.Property(e => e.TicketProductId).HasColumnName("ticketProductID");
            entity.Property(e => e.TicketVendorId).HasColumnName("ticketVendorID");
        });

        modelBuilder.Entity<ProviderBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Provider__3214EC07DF7DCBBF");

            entity.ToTable("ProviderBrand");

            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProviderBrandDomain>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.Domain }).HasName("PK__Provider__1AF84644682F4F02");

            entity.ToTable("ProviderBrandDomain");

            entity.Property(e => e.Domain)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Restriction>(entity =>
        {
            entity.HasKey(e => e.RestrictionId).HasName("pk_Restriction");

            entity.ToTable("Restriction");

            entity.Property(e => e.RestrictionId).HasColumnName("restrictionId");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetsCount).HasColumnName("betsCount");
            entity.Property(e => e.BetsLimit).HasColumnName("betsLimit");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("endTime");
            entity.Property(e => e.Odds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("startTime");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");
        });

        modelBuilder.Entity<RiskBalancerTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RiskBala__3213E83FB1957ADD");

            entity.ToTable("RiskBalancerTracking");

            entity.HasIndex(e => new { e.DrawId, e.VendorId, e.BetType, e.BetContent }, "UC_RiskTracking")
                .IsUnique()
                .IsDescending(true, false, false, false);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveRange).HasColumnName("activeRange");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetType).HasColumnName("betType");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.Odds).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TotalRmbamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalRMBAmount");
            entity.Property(e => e.VendorId).HasColumnName("vendorId");
        });

        modelBuilder.Entity<Rtp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RTP__3214EC074F54E090");

            entity.ToTable("RTP");

            entity.HasIndex(e => new { e.Id, e.ProductId, e.AreaId, e.BetTypeUid }, "ix_RTP").HasFillFactor(90);

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.TotalBetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalWinAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.ToTable("Schedule");

            entity.Property(e => e.Active)
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.Interval).HasColumnName("interval");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<SessionLess>(entity =>
        {
            entity.HasKey(e => e.SessionLessAutoId);

            entity.ToTable("SessionLess");

            entity.Property(e => e.SessionLessAutoId).HasColumnName("SessionLessAutoID");
            entity.Property(e => e.DateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("dateTime");
            entity.Property(e => e.SessionLessKey)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasComment("Session Key it's to pair the Captcha");
            entity.Property(e => e.Value)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Spin>(entity =>
        {
            entity.ToTable("Spin");

            entity.Property(e => e.SpinId).HasColumnName("spinId");
            entity.Property(e => e.BundleId).HasColumnName("bundleId");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("clientIp");
            entity.Property(e => e.Content)
                .HasMaxLength(200)
                .HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.ExchangeRate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("exchangeRate");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
            entity.Property(e => e.PayoutAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("payoutAmount");
            entity.Property(e => e.Platform).HasColumnName("platform");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.StartedNext).HasColumnName("startedNext");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Step).HasColumnName("step");
            entity.Property(e => e.UpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");
        });

        modelBuilder.Entity<SysLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("pk_SysLog");

            entity.ToTable("SysLog");

            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.LogAdminId).HasColumnName("logAdminID");
            entity.Property(e => e.LogClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("logClientIP");
            entity.Property(e => e.LogContent)
                .IsUnicode(false)
                .HasColumnName("logContent");
            entity.Property(e => e.LogDrawId).HasColumnName("logDrawID");
            entity.Property(e => e.LogProductId).HasColumnName("logProductID");
            entity.Property(e => e.LogTime)
                .HasColumnType("datetime")
                .HasColumnName("logTime");
            entity.Property(e => e.LogType).HasColumnName("logType");
            entity.Property(e => e.LogVendorId).HasColumnName("logVendorID");
        });

        modelBuilder.Entity<TraderOnline>(entity =>
        {
            entity.ToTable("TraderOnline");

            entity.Property(e => e.TraderOnlineId).HasColumnName("traderOnlineID");
            entity.Property(e => e.TraderActiveTime)
                .HasColumnType("datetime")
                .HasColumnName("traderActiveTime");
            entity.Property(e => e.TraderAdminId).HasColumnName("traderAdminID");
            entity.Property(e => e.TraderAreaUid).HasColumnName("traderAreaUID");
            entity.Property(e => e.TraderInTime)
                .HasColumnType("datetime")
                .HasColumnName("traderInTime");
            entity.Property(e => e.TraderPlatform).HasColumnName("traderPlatform");
            entity.Property(e => e.TraderProductId).HasColumnName("traderProductID");
        });

        modelBuilder.Entity<Trading>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__Trading__9616D09F88676542");

            entity.ToTable("Trading");

            entity.HasIndex(e => e.TradingBetId, "IX_Trading_1").HasFillFactor(90);

            entity.HasIndex(e => new { e.TradingMemberUid, e.TradingType, e.TradingBetId, e.TradingReferenceNo }, "IX_Trading_2");

            entity.HasIndex(e => e.TradingMemberUid, "IX_Trading_3").HasFillFactor(90);

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingFast3>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingF__9616D09FDBD9B98B");

            entity.ToTable("TradingFast3");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingKeno>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingK__9616D09F4EDA033F");

            entity.ToTable("TradingKeno");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingLadder>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingL__9616D09F4DBF986E");

            entity.ToTable("TradingLadder");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingLuckyDerby>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingL__9616D09F6DFED7EC");

            entity.ToTable("TradingLuckyDerby");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingPayout>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayout");

            entity.ToTable("TradingPayout");

            entity.HasIndex(e => new { e.TradingBetId, e.TradingType, e.TradingReferenceNo }, "IX_TradingPayout_1").HasFillFactor(90);

            entity.HasIndex(e => e.TradingMemberUid, "IX_TradingPayout_2").HasFillFactor(90);

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutFast3>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutFast3");

            entity.ToTable("TradingPayoutFast3");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutKeno>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutKeno");

            entity.ToTable("TradingPayoutKeno");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutLadder>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutLadder");

            entity.ToTable("TradingPayoutLadder");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutLuckyDerby>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutLuckyDerby");

            entity.ToTable("TradingPayoutLuckyDerby");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutPk10>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutPK10");

            entity.ToTable("TradingPayoutPK10");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutRp>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutRPS");

            entity.ToTable("TradingPayoutRPS");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutThaiLottery>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutThaiLottery");

            entity.ToTable("TradingPayoutThaiLottery");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutVnlottery>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutVNLottery");

            entity.ToTable("TradingPayoutVNLottery");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPayoutWukong>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("pk_TradingPayoutWukong");

            entity.ToTable("TradingPayoutWukong");

            entity.Property(e => e.TradingId).HasColumnName("tradingId");
            entity.Property(e => e.TradingArchiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("tradingArchiveDate");
            entity.Property(e => e.TradingBetId).HasColumnName("tradingBetId");
            entity.Property(e => e.TradingCurrencyId).HasColumnName("tradingCurrencyId");
            entity.Property(e => e.TradingCurrencyRate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("tradingCurrencyRate");
            entity.Property(e => e.TradingMemberUid).HasColumnName("tradingMemberUid");
            entity.Property(e => e.TradingMoney)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingMoney");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingReferenceNo");
            entity.Property(e => e.TradingStatus).HasColumnName("tradingStatus");
            entity.Property(e => e.TradingTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingTime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tradingTrxId");
            entity.Property(e => e.TradingType).HasColumnName("tradingType");
            entity.Property(e => e.TradingUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("tradingUpdateTime");
            entity.Property(e => e.TradingVendorId).HasColumnName("tradingVendorId");
            entity.Property(e => e.TradingWalletEnd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletEnd");
            entity.Property(e => e.TradingWalletStart)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tradingWalletStart");
        });

        modelBuilder.Entity<TradingPk10>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingP__9616D09F0DF17568");

            entity.ToTable("TradingPK10");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingRp>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingR__9616D09F51BCFC1A");

            entity.ToTable("TradingRPS");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingThaiLottery>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingT__9616D09F2EB618D5");

            entity.ToTable("TradingThaiLottery");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingVnlottery>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingV__9616D09F5F9F7678");

            entity.ToTable("TradingVNLottery");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TradingWukong>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__TradingW__9616D09F12780223");

            entity.ToTable("TradingWukong");

            entity.Property(e => e.TradingArchiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TradingCurrencyRate).HasColumnType("decimal(18, 7)");
            entity.Property(e => e.TradingMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TradingTrxId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradingUpdateTime).HasColumnType("datetime");
            entity.Property(e => e.TradingWalletEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TradingWalletStart).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TrialPromotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TrialPro__3214EC0752AF4835");

            entity.ToTable("TrialPromotion");

            entity.Property(e => e.BannerUrl)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.PromoName).HasMaxLength(200);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TrialPromotionCurrency>(entity =>
        {
            entity.HasKey(e => new { e.PromoId, e.Currency }).HasName("PK_TrialPromoCurrency");

            entity.ToTable("TrialPromotionCurrency");

            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InitialBalance).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TrialPromotionGame>(entity =>
        {
            entity.HasKey(e => new { e.PromoId, e.GameId }).HasName("PK_TrialPromoGame");

            entity.ToTable("TrialPromotionGame");
        });

        modelBuilder.Entity<TrialPromotionMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TrialPro__3214EC074E026900");

            entity.ToTable("TrialPromotionMember");

            entity.HasIndex(e => new { e.PromoId, e.MemberUid }, "PK_PromotionMember").IsUnique();

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RowTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<TrialPromotionMemberTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TrialPro__3214EC07CE636CA5");

            entity.ToTable("TrialPromotionMemberTransaction");

            entity.HasIndex(e => new { e.TrxRefNo, e.TrxType }, "PK_TrxRefType").IsUnique();

            entity.HasIndex(e => e.PromoMemberId, "ix_trialtrx_memberId");

            entity.HasIndex(e => e.TrxRefNo, "ix_trialtrx_refNo");

            entity.Property(e => e.AfterBal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BeforeBal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrxRefNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrxTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<VAdminRoleProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAdminRoleProduct");

            entity.Property(e => e.AdminForceAttempt).HasColumnName("adminForceAttempt");
            entity.Property(e => e.AdminId).HasColumnName("adminID");
            entity.Property(e => e.AdminLoginIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adminLoginIP");
            entity.Property(e => e.AdminLoginTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adminLoginTime");
            entity.Property(e => e.AdminLogoutTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adminLogoutTime");
            entity.Property(e => e.AdminMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adminMail");
            entity.Property(e => e.AdminRealName)
                .HasMaxLength(50)
                .HasColumnName("adminRealName");
            entity.Property(e => e.AdminRegTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adminRegTime");
            entity.Property(e => e.AdminRole).HasColumnName("adminRole");
            entity.Property(e => e.AdminStatus).HasColumnName("adminStatus");
            entity.Property(e => e.AdminSuperior).HasColumnName("adminSuperior");
            entity.Property(e => e.AdminUpdateTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adminUpdateTime");
            entity.Property(e => e.AdminUsername)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("adminUsername");
            entity.Property(e => e.AdminVendorId).HasColumnName("adminVendorID");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.RoleName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("roleName");
            entity.Property(e => e.RoleTrader).HasColumnName("roleTrader");
        });

        modelBuilder.Entity<VB>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vB");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBfast3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBFast3");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBiLotto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBiLotto");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBkeno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBKeno");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBladder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBLadder");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBluckyDerby>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBLuckyDerby");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBP");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBp45day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBP45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpfast3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPFast3");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount).HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpfast345Day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPFast345Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpiLotto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPiLotto");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpiLotto45Day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPiLotto45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpk10>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPK10");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpkeno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPKeno");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpkeno45Day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPKeno45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpladder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPLadder");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpladder45Day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPLadder45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpluckyDerby>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPLuckyDerby");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpluckyDerby45Day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPLuckyDerby45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBppk10>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPPK10");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBppk1045day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPPK1045Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBprp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPRPS");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBprps45day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPRPS45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpthaiLottery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPThaiLottery");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpthaiLottery45Day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPThaiLottery45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpvnlottery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPVNLottery");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount).HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpvnlottery45Day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPVNLottery45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpwukong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPWukong");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.BetWinCount).HasColumnName("betWinCount");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBpwukong45Day>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBPWukong45Days");

            entity.Property(e => e.ActionTime)
                .HasColumnType("datetime")
                .HasColumnName("actionTime");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBrp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBRPS");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBthaiLottery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBThaiLottery");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBvnlottery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBVNLottery");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VBwukong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBWukong");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AmountWinLose)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountWinLose");
            entity.Property(e => e.BetContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("betContent");
            entity.Property(e => e.BetId).HasColumnName("betId");
            entity.Property(e => e.BetNo).HasColumnName("betNo");
            entity.Property(e => e.BetStatus).HasColumnName("betStatus");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.BetUpdateStatus).HasColumnName("betUpdateStatus");
            entity.Property(e => e.Bets).HasColumnName("bets");
            entity.Property(e => e.ClientIp).HasColumnName("clientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.IsWin).HasColumnName("isWin");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.PlatformOs).HasColumnName("platformOS");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Stake)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("stake");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.TimeBet)
                .HasColumnType("datetime")
                .HasColumnName("timeBet");
        });

        modelBuilder.Entity<VCurrency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vCurrencies");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CurrencyId).HasColumnName("currencyId");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("rate");
            entity.Property(e => e.Rno).HasColumnName("RNO");
        });

        modelBuilder.Entity<VDraw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vDraws");

            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.AreaName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("areaName");
            entity.Property(e => e.AreaStatus).HasColumnName("areaStatus");
            entity.Property(e => e.CancelBetTime).HasColumnName("cancelBetTime");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("createTime");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("deviceId");
            entity.Property(e => e.DrawId).HasColumnName("drawId");
            entity.Property(e => e.DrawNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("drawNo");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("endTime");
            entity.Property(e => e.IsConfirmTime).HasColumnType("datetime");
            entity.Property(e => e.IsConfirmTimeCredit).HasColumnType("datetime");
            entity.Property(e => e.IsManualTime).HasColumnType("datetime");
            entity.Property(e => e.IsPayoutTime).HasColumnType("datetime");
            entity.Property(e => e.IsPayoutTimeCredit).HasColumnType("datetime");
            entity.Property(e => e.IsUnprocessTime).HasColumnType("datetime");
            entity.Property(e => e.IsUnprocessTimeCredit).HasColumnType("datetime");
            entity.Property(e => e.LiveBet)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("liveBet");
            entity.Property(e => e.MoreBet)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("moreBet");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.ProductName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("productName");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.RemarkCredit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("remarkCredit");
            entity.Property(e => e.ResultNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("resultNo");
            entity.Property(e => e.ResultTime)
                .HasColumnType("datetime")
                .HasColumnName("resultTime");
            entity.Property(e => e.ResultTimeCredit)
                .HasColumnType("datetime")
                .HasColumnName("resultTimeCredit");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("startTime");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StatusCredit).HasColumnName("statusCredit");
            entity.Property(e => e.TimeZone).HasColumnName("timeZone");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateTimeCredit)
                .HasColumnType("datetime")
                .HasColumnName("updateTimeCredit");
        });

        modelBuilder.Entity<VMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vMembers");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.IsFun).HasColumnName("isFun");
            entity.Property(e => e.IsKick).HasColumnName("isKick");
            entity.Property(e => e.IsLock).HasColumnName("isLock");
            entity.Property(e => e.IsOnline).HasColumnName("isOnline");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.LastOnlineTime)
                .HasColumnType("datetime")
                .HasColumnName("lastOnlineTime");
            entity.Property(e => e.LoginCount).HasColumnName("loginCount");
            entity.Property(e => e.Logoff)
                .HasColumnType("datetime")
                .HasColumnName("logoff");
            entity.Property(e => e.MemberId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberId");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .HasColumnName("memberName");
            entity.Property(e => e.MemberType).HasColumnName("memberType");
            entity.Property(e => e.MemberUid).HasColumnName("memberUid");
            entity.Property(e => e.RegTime)
                .HasColumnType("datetime")
                .HasColumnName("regTime");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.TokenM)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokenM");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.VendorId).HasColumnName("vendorId");
            entity.Property(e => e.Wallet)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("wallet");
        });

        modelBuilder.Entity<VProductBetConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vProductBetConfig");

            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.AutoBalance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("autoBalance");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.CanBet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("canBet");
            entity.Property(e => e.GlobalLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("globalLimit");
            entity.Property(e => e.Groupname)
                .HasMaxLength(50)
                .HasColumnName("groupname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.Parlay).HasColumnName("parlay");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.RelatedId).HasColumnName("relatedID");
            entity.Property(e => e.StakeMax)
                .IsUnicode(false)
                .HasColumnName("stakeMax");
            entity.Property(e => e.StakeMin)
                .IsUnicode(false)
                .HasColumnName("stakeMin");
            entity.Property(e => e.UserLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("userLimit");
            entity.Property(e => e.VendorId).HasColumnName("vendorId");
        });

        modelBuilder.Entity<VProductConfigType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vProductConfigTypes");

            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.AutoBalance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("autoBalance");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.CanBet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("canBet");
            entity.Property(e => e.ConfigId).HasColumnName("configId");
            entity.Property(e => e.GlobalLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("globalLimit");
            entity.Property(e => e.Groupname)
                .HasMaxLength(50)
                .HasColumnName("groupname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Odds)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("odds");
            entity.Property(e => e.Parlay).HasColumnName("parlay");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.RelatedId).HasColumnName("relatedID");
            entity.Property(e => e.StakeMax)
                .IsUnicode(false)
                .HasColumnName("stakeMax");
            entity.Property(e => e.StakeMin)
                .IsUnicode(false)
                .HasColumnName("stakeMin");
            entity.Property(e => e.UserLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("userLimit");
            entity.Property(e => e.VendorId).HasColumnName("vendorId");
        });

        modelBuilder.Entity<VendorConfig>(entity =>
        {
            entity.HasKey(e => e.VendorId);

            entity.ToTable("VendorConfig");

            entity.Property(e => e.VendorId)
                .ValueGeneratedNever()
                .HasColumnName("vendorId");
            entity.Property(e => e.ActiveProducts)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AuthParam)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AuthUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("authUrl");
            entity.Property(e => e.AuthUrlExt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("authUrlExt");
            entity.Property(e => e.AuthUrlFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("authUrlFile");
            entity.Property(e => e.CashParam)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CashUrl)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("cashUrl");
            entity.Property(e => e.CashUrlExt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("cashUrlExt");
            entity.Property(e => e.CashUrlFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cashUrlFile");
            entity.Property(e => e.FunCurrency)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('UUS')");
            entity.Property(e => e.MaintenanceLink)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("maintenanceLink");
            entity.Property(e => e.OperatorId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("operatorId");
            entity.Property(e => e.RedirectedProtocol).HasColumnName("redirectedProtocol");
            entity.Property(e => e.ReportPassword)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SecretKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("secretKey");
            entity.Property(e => e.SiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("siteCode");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VendorName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendorName");
            entity.Property(e => e.VendorType)
                .HasDefaultValueSql("((1))")
                .HasColumnName("vendorType");
            entity.Property(e => e.WalletUrl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("walletUrl");

            entity.HasOne(d => d.VendorWalletConfig).WithMany(p => p.VendorConfigs)
                .HasForeignKey(d => d.VendorWalletConfigId)
                .HasConstraintName("FK_WalletConfig");
        });

        modelBuilder.Entity<VendorConfigSideMenuSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VendorCo__3214EC07CD02D130");

            entity.ToTable("VendorConfigSideMenuSetting");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorConfigSideMenuSettings)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor");
        });

        modelBuilder.Entity<VendorCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VendorCu__3214EC07D613F30D");

            entity.ToTable("VendorCurrency");
        });

        modelBuilder.Entity<VendorDomainBo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VendorDomainBO");

            entity.Property(e => e.CasHost)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomainAutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("domainAutoId");
            entity.Property(e => e.DomainName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("domainName");
            entity.Property(e => e.DomainVendorId).HasColumnName("domainVendorId");
        });

        modelBuilder.Entity<VendorDomainBowhitelist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VendorDomainBOWhitelist");

            entity.Property(e => e.WhiteListDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("whiteListDesc");
            entity.Property(e => e.WhiteListId)
                .ValueGeneratedOnAdd()
                .HasColumnName("whiteListId");
            entity.Property(e => e.WhiteListIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("whiteListIP");
            entity.Property(e => e.WhiteListSubnet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("whiteListSubnet");
            entity.Property(e => e.WhiteListVendorId).HasColumnName("whiteListVendorId");
        });

        modelBuilder.Entity<VendorDomainFe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VendorDomainFE");

            entity.Property(e => e.DomainAutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("domainAutoId");
            entity.Property(e => e.DomainName)
                .IsUnicode(false)
                .HasColumnName("domainName");
            entity.Property(e => e.DomainSecure).HasColumnName("domainSecure");
            entity.Property(e => e.DomainVendorId).HasColumnName("domainVendorId");
            entity.Property(e => e.IsMobileHtml).HasColumnName("isMobileHTML");
        });

        modelBuilder.Entity<VendorLimitGroup>(entity =>
        {
            entity.HasKey(e => e.LimitId);

            entity.ToTable("VendorLimitGroup");

            entity.Property(e => e.LimitId).HasColumnName("limitId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.VendorId).HasColumnName("vendorId");
        });

        modelBuilder.Entity<VendorLimitProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("VendorLimitProfile");

            entity.Property(e => e.ProfileId).HasColumnName("profileId");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profileName");
            entity.Property(e => e.ProfileVendors)
                .IsUnicode(false)
                .HasColumnName("profileVendors");
        });

        modelBuilder.Entity<VendorLimitProfileSetting>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("VendorLimitProfileSetting");

            entity.Property(e => e.ConfigId).HasColumnName("configId");
            entity.Property(e => e.BetTypeUid).HasColumnName("betTypeUid");
            entity.Property(e => e.ProfileId).HasColumnName("profileId");
            entity.Property(e => e.StakeMax)
                .IsUnicode(false)
                .HasColumnName("stakeMax");
            entity.Property(e => e.StakeMin)
                .IsUnicode(false)
                .HasColumnName("stakeMin");
        });

        modelBuilder.Entity<VendorWalletConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VendorWa__3214EC0783D70EBB");

            entity.ToTable("VendorWalletConfig");

            entity.Property(e => e.ApiPaths)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HttpAcceptType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HttpContentType)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HttpMethod)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MerchantId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MerchantPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParamMapKeys)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ResultMapKeys)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VendorWalletProductConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VendorWalletProductConfig");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WalletProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WalletPr__3214EC070230CB0F");

            entity.ToTable("WalletProduct");

            entity.HasIndex(e => e.ProductId, "UQ_ProductId").IsUnique();

            entity.Property(e => e.GameId).IsUnicode(false);
            entity.Property(e => e.MerchantId).IsUnicode(false);
            entity.Property(e => e.MerchantPassword).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
