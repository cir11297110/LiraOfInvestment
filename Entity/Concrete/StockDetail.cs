using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{


    public class StockDetail:IEntity
    {
        public Defaultkeystatistics defaultKeyStatistics { get; set; }
        public Details details { get; set; }
        public Summaryprofile summaryProfile { get; set; }
        public Recommendationtrend recommendationTrend { get; set; }
        public Financialstemplate financialsTemplate { get; set; }
        public Majordirectholders majorDirectHolders { get; set; }
        public Earnings earnings { get; set; }
        public Price price { get; set; }
        public Fundownership fundOwnership { get; set; }
        public Insidertransactions insiderTransactions { get; set; }
        public Insiderholders insiderHolders { get; set; }
        public Netsharepurchaseactivity netSharePurchaseActivity { get; set; }
        public Majorholdersbreakdown majorHoldersBreakdown { get; set; }
        public Financialdata financialData { get; set; }
        public Quotetype quoteType { get; set; }
        public Institutionownership institutionOwnership { get; set; }
        public Calendarevents calendarEvents { get; set; }
        public Summarydetail summaryDetail { get; set; }
        public string symbol { get; set; }
        public Esgscores esgScores { get; set; }
        public Upgradedowngradehistory upgradeDowngradeHistory { get; set; }
        public Pageviews pageViews { get; set; }
    }

    public class Defaultkeystatistics
    {
        public Annualholdingsturnover annualHoldingsTurnover { get; set; }
        public Enterprisetorevenue enterpriseToRevenue { get; set; }
        public Beta3year beta3Year { get; set; }
        public Profitmargins profitMargins { get; set; }
        public Enterprisetoebitda enterpriseToEbitda { get; set; }
        public _52Weekchange _52WeekChange { get; set; }
        public Morningstarriskrating morningStarRiskRating { get; set; }
        public Forwardeps forwardEps { get; set; }
        public Revenuequarterlygrowth revenueQuarterlyGrowth { get; set; }
        public Sharesoutstanding sharesOutstanding { get; set; }
        public Fundinceptiondate fundInceptionDate { get; set; }
        public Annualreportexpenseratio annualReportExpenseRatio { get; set; }
        public Totalassets totalAssets { get; set; }
        public Bookvalue bookValue { get; set; }
        public Sharesshort sharesShort { get; set; }
        public Sharespercentsharesout sharesPercentSharesOut { get; set; }
        public object fundFamily { get; set; }
        public Lastfiscalyearend lastFiscalYearEnd { get; set; }
        public Heldpercentinstitutions heldPercentInstitutions { get; set; }
        public Netincometocommon netIncomeToCommon { get; set; }
        public Trailingeps trailingEps { get; set; }
        public Lastdividendvalue lastDividendValue { get; set; }
        public Sandp52weekchange SandP52WeekChange { get; set; }
        public Pricetobook priceToBook { get; set; }
        public Heldpercentinsiders heldPercentInsiders { get; set; }
        public Nextfiscalyearend nextFiscalYearEnd { get; set; }
        public Yield yield { get; set; }
        public Mostrecentquarter mostRecentQuarter { get; set; }
        public Shortratio shortRatio { get; set; }
        public Sharesshortpreviousmonthdate sharesShortPreviousMonthDate { get; set; }
        public Floatshares floatShares { get; set; }
        public Beta beta { get; set; }
        public Enterprisevalue enterpriseValue { get; set; }
        public Pricehint priceHint { get; set; }
        public Threeyearaveragereturn threeYearAverageReturn { get; set; }
        public Lastsplitdate lastSplitDate { get; set; }
        public string lastSplitFactor { get; set; }
        public object legalType { get; set; }
        public Lastdividenddate lastDividendDate { get; set; }
        public Morningstaroverallrating morningStarOverallRating { get; set; }
        public Earningsquarterlygrowth earningsQuarterlyGrowth { get; set; }
        public Pricetosalestrailing12months priceToSalesTrailing12Months { get; set; }
        public Dateshortinterest dateShortInterest { get; set; }
        public Pegratio pegRatio { get; set; }
        public Ytdreturn ytdReturn { get; set; }
        public Forwardpe forwardPE { get; set; }
        public int maxAge { get; set; }
        public Lastcapgain lastCapGain { get; set; }
        public Shortpercentoffloat shortPercentOfFloat { get; set; }
        public Sharesshortpriormonth sharesShortPriorMonth { get; set; }
        public Impliedsharesoutstanding impliedSharesOutstanding { get; set; }
        public object category { get; set; }
        public Fiveyearaveragereturn fiveYearAverageReturn { get; set; }
    }

    public class Annualholdingsturnover
    {
    }

    public class Enterprisetorevenue
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Beta3year
    {
    }

    public class Profitmargins
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Enterprisetoebitda
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class _52Weekchange
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Morningstarriskrating
    {
    }

    public class Forwardeps
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Revenuequarterlygrowth
    {
    }

    public class Sharesoutstanding
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Fundinceptiondate
    {
    }

    public class Annualreportexpenseratio
    {
    }

    public class Totalassets
    {
    }

    public class Bookvalue
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Sharesshort
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Sharespercentsharesout
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Lastfiscalyearend
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Heldpercentinstitutions
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Netincometocommon
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Trailingeps
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Lastdividendvalue
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Sandp52weekchange
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Pricetobook
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Heldpercentinsiders
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Nextfiscalyearend
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Yield
    {
    }

    public class Mostrecentquarter
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Shortratio
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Sharesshortpreviousmonthdate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Floatshares
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Beta
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Enterprisevalue
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Pricehint
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Threeyearaveragereturn
    {
    }

    public class Lastsplitdate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Lastdividenddate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Morningstaroverallrating
    {
    }

    public class Earningsquarterlygrowth
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Pricetosalestrailing12months
    {
    }

    public class Dateshortinterest
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Pegratio
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Ytdreturn
    {
    }

    public class Forwardpe
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Lastcapgain
    {
    }

    public class Shortpercentoffloat
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Sharesshortpriormonth
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Impliedsharesoutstanding
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Fiveyearaveragereturn
    {
    }

    public class Details
    {
    }

    public class Summaryprofile
    {
        public string zip { get; set; }
        public string sector { get; set; }
        public int fullTimeEmployees { get; set; }
        public string longBusinessSummary { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public object[] companyOfficers { get; set; }
        public string website { get; set; }
        public int maxAge { get; set; }
        public string address1 { get; set; }
        public string industry { get; set; }
    }

    public class Recommendationtrend
    {
        public Trend[] trend { get; set; }
        public int maxAge { get; set; }
    }

    public class Trend
    {
        public string period { get; set; }
        public int strongBuy { get; set; }
        public int buy { get; set; }
        public int hold { get; set; }
        public int sell { get; set; }
        public int strongSell { get; set; }
    }

    public class Financialstemplate
    {
        public string code { get; set; }
        public int maxAge { get; set; }
    }

    public class Majordirectholders
    {
        public object[] holders { get; set; }
        public int maxAge { get; set; }
    }

    public class Earnings
    {
        public int maxAge { get; set; }
        public Earningschart earningsChart { get; set; }
        public Financialschart financialsChart { get; set; }
        public string financialCurrency { get; set; }
    }

    public class Earningschart
    {
        public Quarterly[] quarterly { get; set; }
        public Currentquarterestimate currentQuarterEstimate { get; set; }
        public string currentQuarterEstimateDate { get; set; }
        public int currentQuarterEstimateYear { get; set; }
        public Earningsdate[] earningsDate { get; set; }
    }

    public class Currentquarterestimate
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Quarterly
    {
        public string date { get; set; }
        public Actual actual { get; set; }
        public Estimate estimate { get; set; }
    }

    public class Actual
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Estimate
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Earningsdate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Financialschart
    {
        public Yearly[] yearly { get; set; }
        public Quarterly1[] quarterly { get; set; }
    }

    public class Yearly
    {
        public int date { get; set; }
        public Revenue revenue { get; set; }
        public Earnings1 earnings { get; set; }
    }

    public class Revenue
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Earnings1
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Quarterly1
    {
        public string date { get; set; }
        public Revenue1 revenue { get; set; }
        public Earnings2 earnings { get; set; }
    }

    public class Revenue1
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Earnings2
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Price
    {
        public string quoteSourceName { get; set; }
        public Regularmarketopen regularMarketOpen { get; set; }
        public Averagedailyvolume3month averageDailyVolume3Month { get; set; }
        public string exchange { get; set; }
        public int regularMarketTime { get; set; }
        public Volume24hr volume24Hr { get; set; }
        public Regularmarketdayhigh regularMarketDayHigh { get; set; }
        public string shortName { get; set; }
        public Averagedailyvolume10day averageDailyVolume10Day { get; set; }
        public string longName { get; set; }
        public Regularmarketchange regularMarketChange { get; set; }
        public string currencySymbol { get; set; }
        public Regularmarketpreviousclose regularMarketPreviousClose { get; set; }
        public int postMarketTime { get; set; }
        public Premarketprice preMarketPrice { get; set; }
        public int preMarketTime { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public object toCurrency { get; set; }
        public Postmarketchange postMarketChange { get; set; }
        public Postmarketprice postMarketPrice { get; set; }
        public string exchangeName { get; set; }
        public Premarketchange preMarketChange { get; set; }
        public Circulatingsupply circulatingSupply { get; set; }
        public Regularmarketdaylow regularMarketDayLow { get; set; }
        public Pricehint1 priceHint { get; set; }
        public string currency { get; set; }
        public Regularmarketprice regularMarketPrice { get; set; }
        public Regularmarketvolume regularMarketVolume { get; set; }
        public object lastMarket { get; set; }
        public string regularMarketSource { get; set; }
        public Openinterest openInterest { get; set; }
        public string marketState { get; set; }
        public object underlyingSymbol { get; set; }
        public Marketcap marketCap { get; set; }
        public string quoteType { get; set; }
        public Premarketchangepercent preMarketChangePercent { get; set; }
        public Volumeallcurrencies volumeAllCurrencies { get; set; }
        public string postMarketSource { get; set; }
        public Strikeprice strikePrice { get; set; }
        public string symbol { get; set; }
        public Postmarketchangepercent postMarketChangePercent { get; set; }
        public string preMarketSource { get; set; }
        public int maxAge { get; set; }
        public object fromCurrency { get; set; }
        public Regularmarketchangepercent regularMarketChangePercent { get; set; }
    }

    public class Regularmarketopen
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Averagedailyvolume3month
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Volume24hr
    {
    }

    public class Regularmarketdayhigh
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Averagedailyvolume10day
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Regularmarketchange
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarketpreviousclose
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Premarketprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Postmarketchange
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Postmarketprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Premarketchange
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Circulatingsupply
    {
    }

    public class Regularmarketdaylow
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Pricehint1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Regularmarketprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarketvolume
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Openinterest
    {
    }

    public class Marketcap
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Premarketchangepercent
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Volumeallcurrencies
    {
    }

    public class Strikeprice
    {
    }

    public class Postmarketchangepercent
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarketchangepercent
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Fundownership
    {
        public int maxAge { get; set; }
        public Ownershiplist[] ownershipList { get; set; }
    }

    public class Ownershiplist
    {
        public int maxAge { get; set; }
        public Reportdate reportDate { get; set; }
        public string organization { get; set; }
        public Pctheld pctHeld { get; set; }
        public Position position { get; set; }
        public Value value { get; set; }
        public Pctchange pctChange { get; set; }
    }

    public class Reportdate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Pctheld
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Position
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Value
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Pctchange
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Insidertransactions
    {
        public Transaction[] transactions { get; set; }
        public int maxAge { get; set; }
    }

    public class Transaction
    {
        public string filerName { get; set; }
        public string transactionText { get; set; }
        public string moneyText { get; set; }
        public string ownership { get; set; }
        public Startdate startDate { get; set; }
        public Value1 value { get; set; }
        public string filerRelation { get; set; }
        public Shares shares { get; set; }
        public string filerUrl { get; set; }
        public int maxAge { get; set; }
    }

    public class Startdate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Value1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Shares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Insiderholders
    {
        public Holder[] holders { get; set; }
        public int maxAge { get; set; }
    }

    public class Holder
    {
        public int maxAge { get; set; }
        public string name { get; set; }
        public string relation { get; set; }
        public string url { get; set; }
        public string transactionDescription { get; set; }
        public Latesttransdate latestTransDate { get; set; }
        public Positiondirect positionDirect { get; set; }
        public Positiondirectdate positionDirectDate { get; set; }
        public Positionindirect positionIndirect { get; set; }
        public Positionindirectdate positionIndirectDate { get; set; }
    }

    public class Latesttransdate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Positiondirect
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Positiondirectdate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Positionindirect
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Positionindirectdate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Netsharepurchaseactivity
    {
        public string period { get; set; }
        public Netpercentinsidershares netPercentInsiderShares { get; set; }
        public Netinfocount netInfoCount { get; set; }
        public Totalinsidershares totalInsiderShares { get; set; }
        public Buyinfoshares buyInfoShares { get; set; }
        public Buypercentinsidershares buyPercentInsiderShares { get; set; }
        public Sellinfocount sellInfoCount { get; set; }
        public Sellinfoshares sellInfoShares { get; set; }
        public Sellpercentinsidershares sellPercentInsiderShares { get; set; }
        public int maxAge { get; set; }
        public Buyinfocount buyInfoCount { get; set; }
        public Netinfoshares netInfoShares { get; set; }
    }

    public class Netpercentinsidershares
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Netinfocount
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalinsidershares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Buyinfoshares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Buypercentinsidershares
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Sellinfocount
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Sellinfoshares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Sellpercentinsidershares
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Buyinfocount
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Netinfoshares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Majorholdersbreakdown
    {
        public int maxAge { get; set; }
        public Insiderspercentheld insidersPercentHeld { get; set; }
        public Institutionspercentheld institutionsPercentHeld { get; set; }
        public Institutionsfloatpercentheld institutionsFloatPercentHeld { get; set; }
        public Institutionscount institutionsCount { get; set; }
    }

    public class Insiderspercentheld
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Institutionspercentheld
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Institutionsfloatpercentheld
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Institutionscount
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Financialdata
    {
        public Ebitdamargins ebitdaMargins { get; set; }
        public Profitmargins1 profitMargins { get; set; }
        public Grossmargins grossMargins { get; set; }
        public Operatingcashflow operatingCashflow { get; set; }
        public Revenuegrowth revenueGrowth { get; set; }
        public Operatingmargins operatingMargins { get; set; }
        public Ebitda ebitda { get; set; }
        public Targetlowprice targetLowPrice { get; set; }
        public string recommendationKey { get; set; }
        public Grossprofits grossProfits { get; set; }
        public Freecashflow freeCashflow { get; set; }
        public Targetmedianprice targetMedianPrice { get; set; }
        public Currentprice currentPrice { get; set; }
        public Earningsgrowth earningsGrowth { get; set; }
        public Currentratio currentRatio { get; set; }
        public Returnonassets returnOnAssets { get; set; }
        public Numberofanalystopinions numberOfAnalystOpinions { get; set; }
        public Targetmeanprice targetMeanPrice { get; set; }
        public Debttoequity debtToEquity { get; set; }
        public Returnonequity returnOnEquity { get; set; }
        public Targethighprice targetHighPrice { get; set; }
        public Totalcash totalCash { get; set; }
        public Totaldebt totalDebt { get; set; }
        public Totalrevenue totalRevenue { get; set; }
        public Totalcashpershare totalCashPerShare { get; set; }
        public string financialCurrency { get; set; }
        public int maxAge { get; set; }
        public Revenuepershare revenuePerShare { get; set; }
        public Quickratio quickRatio { get; set; }
        public Recommendationmean recommendationMean { get; set; }
    }

    public class Ebitdamargins
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Profitmargins1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Grossmargins
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Operatingcashflow
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Revenuegrowth
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Operatingmargins
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Ebitda
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Targetlowprice
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Grossprofits
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Freecashflow
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Targetmedianprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Currentprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Earningsgrowth
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Currentratio
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Returnonassets
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Numberofanalystopinions
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Targetmeanprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Debttoequity
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Returnonequity
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Targethighprice
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Totalcash
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totaldebt
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalrevenue
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcashpershare
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Revenuepershare
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Quickratio
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Recommendationmean
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Quotetype
    {
        public string exchange { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public bool isEsgPopulated { get; set; }
        public string gmtOffSetMilliseconds { get; set; }
        public string quoteType { get; set; }
        public string symbol { get; set; }
        public string messageBoardId { get; set; }
        public string market { get; set; }
    }

    public class Institutionownership
    {
        public int maxAge { get; set; }
        public Ownershiplist1[] ownershipList { get; set; }
    }

    public class Ownershiplist1
    {
        public int maxAge { get; set; }
        public Reportdate1 reportDate { get; set; }
        public string organization { get; set; }
        public Pctheld1 pctHeld { get; set; }
        public Position1 position { get; set; }
        public Value2 value { get; set; }
        public Pctchange1 pctChange { get; set; }
    }

    public class Reportdate1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Pctheld1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Position1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Value2
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Pctchange1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Calendarevents
    {
        public int maxAge { get; set; }
        public Earnings3 earnings { get; set; }
        public Exdividenddate exDividendDate { get; set; }
        public Dividenddate dividendDate { get; set; }
    }

    public class Earnings3
    {
        public Earningsdate1[] earningsDate { get; set; }
        public Earningsaverage earningsAverage { get; set; }
        public Earningslow earningsLow { get; set; }
        public Earningshigh earningsHigh { get; set; }
        public Revenueaverage revenueAverage { get; set; }
        public Revenuelow revenueLow { get; set; }
        public Revenuehigh revenueHigh { get; set; }
    }

    public class Earningsaverage
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Earningslow
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Earningshigh
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Revenueaverage
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Revenuelow
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Revenuehigh
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Earningsdate1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Exdividenddate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Dividenddate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Summarydetail
    {
        public Previousclose previousClose { get; set; }
        public Regularmarketopen1 regularMarketOpen { get; set; }
        public Twohundreddayaverage twoHundredDayAverage { get; set; }
        public Trailingannualdividendyield trailingAnnualDividendYield { get; set; }
        public Payoutratio payoutRatio { get; set; }
        public Volume24hr1 volume24Hr { get; set; }
        public Regularmarketdayhigh1 regularMarketDayHigh { get; set; }
        public Navprice navPrice { get; set; }
        public Averagedailyvolume10day1 averageDailyVolume10Day { get; set; }
        public Totalassets1 totalAssets { get; set; }
        public Regularmarketpreviousclose1 regularMarketPreviousClose { get; set; }
        public Fiftydayaverage fiftyDayAverage { get; set; }
        public Trailingannualdividendrate trailingAnnualDividendRate { get; set; }
        public Open open { get; set; }
        public object toCurrency { get; set; }
        public Averagevolume10days averageVolume10days { get; set; }
        public Expiredate expireDate { get; set; }
        public Yield1 yield { get; set; }
        public object algorithm { get; set; }
        public Dividendrate dividendRate { get; set; }
        public Exdividenddate1 exDividendDate { get; set; }
        public Beta1 beta { get; set; }
        public Circulatingsupply1 circulatingSupply { get; set; }
        public Startdate1 startDate { get; set; }
        public Regularmarketdaylow1 regularMarketDayLow { get; set; }
        public Pricehint2 priceHint { get; set; }
        public string currency { get; set; }
        public Trailingpe trailingPE { get; set; }
        public Regularmarketvolume1 regularMarketVolume { get; set; }
        public object lastMarket { get; set; }
        public Maxsupply maxSupply { get; set; }
        public Openinterest1 openInterest { get; set; }
        public Marketcap1 marketCap { get; set; }
        public Volumeallcurrencies1 volumeAllCurrencies { get; set; }
        public Strikeprice1 strikePrice { get; set; }
        public Averagevolume averageVolume { get; set; }
        public Pricetosalestrailing12months1 priceToSalesTrailing12Months { get; set; }
        public Daylow dayLow { get; set; }
        public Ask ask { get; set; }
        public Ytdreturn1 ytdReturn { get; set; }
        public Asksize askSize { get; set; }
        public Volume volume { get; set; }
        public Fiftytwoweekhigh fiftyTwoWeekHigh { get; set; }
        public Forwardpe1 forwardPE { get; set; }
        public int maxAge { get; set; }
        public object fromCurrency { get; set; }
        public Fiveyearavgdividendyield fiveYearAvgDividendYield { get; set; }
        public Fiftytwoweeklow fiftyTwoWeekLow { get; set; }
        public Bid bid { get; set; }
        public bool tradeable { get; set; }
        public Dividendyield dividendYield { get; set; }
        public Bidsize bidSize { get; set; }
        public Dayhigh dayHigh { get; set; }
        public object coinMarketCapLink { get; set; }
    }

    public class Previousclose
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarketopen1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Twohundreddayaverage
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Trailingannualdividendyield
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Payoutratio
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Volume24hr1
    {
    }

    public class Regularmarketdayhigh1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Navprice
    {
    }

    public class Averagedailyvolume10day1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalassets1
    {
    }

    public class Regularmarketpreviousclose1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Fiftydayaverage
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Trailingannualdividendrate
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Open
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Averagevolume10days
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Expiredate
    {
    }

    public class Yield1
    {
    }

    public class Dividendrate
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Exdividenddate1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Beta1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Circulatingsupply1
    {
    }

    public class Startdate1
    {
    }

    public class Regularmarketdaylow1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Pricehint2
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Trailingpe
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarketvolume1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Maxsupply
    {
    }

    public class Openinterest1
    {
    }

    public class Marketcap1
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Volumeallcurrencies1
    {
    }

    public class Strikeprice1
    {
    }

    public class Averagevolume
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Pricetosalestrailing12months1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Daylow
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Ask
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Ytdreturn1
    {
    }

    public class Asksize
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Volume
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Fiftytwoweekhigh
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Forwardpe1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Fiveyearavgdividendyield
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Fiftytwoweeklow
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Bid
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Dividendyield
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Bidsize
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Dayhigh
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Esgscores
    {
        public bool palmOil { get; set; }
        public Peersocialperformance peerSocialPerformance { get; set; }
        public bool controversialWeapons { get; set; }
        public int ratingMonth { get; set; }
        public bool gambling { get; set; }
        public Socialscore socialScore { get; set; }
        public bool nuclear { get; set; }
        public bool furLeather { get; set; }
        public bool alcoholic { get; set; }
        public bool gmo { get; set; }
        public bool catholic { get; set; }
        public object socialPercentile { get; set; }
        public Peergovernanceperformance peerGovernancePerformance { get; set; }
        public int peerCount { get; set; }
        public string[] relatedControversy { get; set; }
        public Governancescore governanceScore { get; set; }
        public object environmentPercentile { get; set; }
        public bool animalTesting { get; set; }
        public Peeresgscoreperformance peerEsgScorePerformance { get; set; }
        public bool tobacco { get; set; }
        public Totalesg totalEsg { get; set; }
        public int highestControversy { get; set; }
        public string esgPerformance { get; set; }
        public bool coal { get; set; }
        public Peerhighestcontroversyperformance peerHighestControversyPerformance { get; set; }
        public bool pesticides { get; set; }
        public bool adult { get; set; }
        public int ratingYear { get; set; }
        public int maxAge { get; set; }
        public Percentile percentile { get; set; }
        public string peerGroup { get; set; }
        public bool smallArms { get; set; }
        public Peerenvironmentperformance peerEnvironmentPerformance { get; set; }
        public Environmentscore environmentScore { get; set; }
        public object governancePercentile { get; set; }
        public bool militaryContract { get; set; }
    }

    public class Peersocialperformance
    {
        public float min { get; set; }
        public float avg { get; set; }
        public float max { get; set; }
    }

    public class Socialscore
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Peergovernanceperformance
    {
        public float min { get; set; }
        public float avg { get; set; }
        public float max { get; set; }
    }

    public class Governancescore
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Peeresgscoreperformance
    {
        public float min { get; set; }
        public float avg { get; set; }
        public float max { get; set; }
    }

    public class Totalesg
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Peerhighestcontroversyperformance
    {
        public int min { get; set; }
        public float avg { get; set; }
        public int max { get; set; }
    }

    public class Percentile
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Peerenvironmentperformance
    {
        public float min { get; set; }
        public float avg { get; set; }
        public float max { get; set; }
    }

    public class Environmentscore
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Upgradedowngradehistory
    {
        public History[] history { get; set; }
        public int maxAge { get; set; }
    }

    public class History
    {
        public int epochGradeDate { get; set; }
        public string firm { get; set; }
        public string toGrade { get; set; }
        public string fromGrade { get; set; }
        public string action { get; set; }
    }

    public class Pageviews
    {
        public string shortTermTrend { get; set; }
        public string midTermTrend { get; set; }
        public string longTermTrend { get; set; }
        public int maxAge { get; set; }
    }

}

