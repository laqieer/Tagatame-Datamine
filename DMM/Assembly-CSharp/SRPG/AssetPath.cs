// Decompiled with JetBrains decompiler
// Type: SRPG.AssetPath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E66")]
  public static class AssetPath
  {
    [Token(Token = "0x4002BE8")]
    [FieldOffset(Offset = "0x0")]
    private static StringBuilder mSB;
    [Token(Token = "0x4002BE9")]
    [FieldOffset(Offset = "0x4")]
    private static string JobResourceID_None;

    [Token(Token = "0x6003B86")]
    [Address(RVA = "0x10D3000", Offset = "0x10D1E00", VA = "0x110D3000")]
    private static string GetJobResourceID(JobParam job) => (string) null;

    [Token(Token = "0x6003B87")]
    [Address(RVA = "0x10D26F0", Offset = "0x10D14F0", VA = "0x110D26F0")]
    public static string AbilityIcon(AbilityParam ability) => (string) null;

    [Token(Token = "0x6003B88")]
    [Address(RVA = "0x10D37C0", Offset = "0x10D25C0", VA = "0x110D37C0")]
    public static string LocalMap(string sceneName) => (string) null;

    [Token(Token = "0x6003B89")]
    [Address(RVA = "0x10D3880", Offset = "0x10D2680", VA = "0x110D3880")]
    public static string Navigation(QuestParam quest) => (string) null;

    [Token(Token = "0x6003B8A")]
    [Address(RVA = "0x10D3950", Offset = "0x10D2750", VA = "0x110D3950")]
    public static string QuestEvent(string eventName) => (string) null;

    [Token(Token = "0x6003B8B")]
    [Address(RVA = "0x10D4910", Offset = "0x10D3710", VA = "0x110D4910")]
    public static string UnitImage(UnitParam unit, string jobName) => (string) null;

    [Token(Token = "0x6003B8C")]
    [Address(RVA = "0x10D4850", Offset = "0x10D3650", VA = "0x110D4850")]
    public static string UnitImage(string unit) => (string) null;

    [Token(Token = "0x6003B8D")]
    [Address(RVA = "0x10D5340", Offset = "0x10D4140", VA = "0x110D5340")]
    public static string UnitSkinImage(UnitParam unit, ArtifactParam skin, string jobName)
    {
      return (string) null;
    }

    [Token(Token = "0x6003B8E")]
    [Address(RVA = "0x10D46E0", Offset = "0x10D34E0", VA = "0x110D46E0")]
    public static string UnitImage2(UnitParam unit, string jobName) => (string) null;

    [Token(Token = "0x6003B8F")]
    [Address(RVA = "0x10D50C0", Offset = "0x10D3EC0", VA = "0x110D50C0")]
    public static string UnitSkinImage2(UnitParam unit, ArtifactParam skin, string jobName)
    {
      return (string) null;
    }

    [Token(Token = "0x6003B90")]
    [Address(RVA = "0x10D4570", Offset = "0x10D3370", VA = "0x110D4570")]
    public static string UnitIconSmall(UnitParam unit, string jobName) => (string) null;

    [Token(Token = "0x6003B91")]
    [Address(RVA = "0x10D4F80", Offset = "0x10D3D80", VA = "0x110D4F80")]
    public static string UnitSkinIconSmall(UnitParam unit, ArtifactParam skin, string jobName)
    {
      return (string) null;
    }

    [Token(Token = "0x6003B92")]
    [Address(RVA = "0x10D4400", Offset = "0x10D3200", VA = "0x110D4400")]
    public static string UnitIconMedium(UnitParam unit, string jobName) => (string) null;

    [Token(Token = "0x6003B93")]
    [Address(RVA = "0x10D4D00", Offset = "0x10D3B00", VA = "0x110D4D00")]
    public static string UnitSkinIconMedium(UnitParam unit, ArtifactParam skin, string jobName)
    {
      return (string) null;
    }

    [Token(Token = "0x6003B94")]
    [Address(RVA = "0x10D4290", Offset = "0x10D3090", VA = "0x110D4290")]
    public static string UnitEyeImage(UnitParam unit, string jobName) => (string) null;

    [Token(Token = "0x6003B95")]
    [Address(RVA = "0x10D4A80", Offset = "0x10D3880", VA = "0x110D4A80")]
    public static string UnitSkinEyeImage(UnitParam unit, ArtifactParam skin, string jobName)
    {
      return (string) null;
    }

    [Token(Token = "0x6003B96")]
    [Address(RVA = "0x10D3660", Offset = "0x10D2460", VA = "0x110D3660")]
    public static string JobIconSmall(JobParam job) => (string) null;

    [Token(Token = "0x6003B97")]
    [Address(RVA = "0x10D3530", Offset = "0x10D2330", VA = "0x110D3530")]
    public static string JobIconMedium(JobParam job) => (string) null;

    [Token(Token = "0x6003B98")]
    [Address(RVA = "0x10D4100", Offset = "0x10D2F00", VA = "0x110D4100")]
    public static string UnitCurrentJobIconSmall(UnitData unit) => (string) null;

    [Token(Token = "0x6003B99")]
    [Address(RVA = "0x10D3F70", Offset = "0x10D2D70", VA = "0x110D3F70")]
    public static string UnitCurrentJobIconMedium(UnitData unit) => (string) null;

    [Token(Token = "0x6003B9A")]
    [Address(RVA = "0x10D3790", Offset = "0x10D2590", VA = "0x110D3790")]
    public static string JobIconThumbnail() => (string) null;

    [Token(Token = "0x6003B9B")]
    [Address(RVA = "0x10D3460", Offset = "0x10D2260", VA = "0x110D3460")]
    public static string JobEquipment(JobParam job) => (string) null;

    [Token(Token = "0x6003B9C")]
    [Address(RVA = "0x10D2890", Offset = "0x10D1690", VA = "0x110D2890")]
    public static string Artifacts(ArtifactParam artifalct) => (string) null;

    [Token(Token = "0x6003B9D")]
    [Address(RVA = "0x10D3210", Offset = "0x10D2010", VA = "0x110D3210")]
    public static string ItemIcon(ItemParam param) => (string) null;

    [Token(Token = "0x6003B9E")]
    [Address(RVA = "0x10D3130", Offset = "0x10D1F30", VA = "0x110D3130")]
    public static string ItemIcon(string iconName) => (string) null;

    [Token(Token = "0x6003B9F")]
    [Address(RVA = "0x10D3AD0", Offset = "0x10D28D0", VA = "0x110D3AD0")]
    public static string SkillEffect(SkillParam skill, string effect_name = null) => (string) null;

    [Token(Token = "0x6003BA0")]
    [Address(RVA = "0x10D3A10", Offset = "0x10D2810", VA = "0x110D3A10")]
    public static string SkillEffect(string skill_effect_path) => (string) null;

    [Token(Token = "0x6003BA1")]
    [Address(RVA = "0x10D2BA0", Offset = "0x10D19A0", VA = "0x110D2BA0")]
    public static string BuffDebuffEffect(string _file_name) => (string) null;

    [Token(Token = "0x6003BA2")]
    [Address(RVA = "0x10D2A20", Offset = "0x10D1820", VA = "0x110D2A20")]
    public static string BuffDebuffEffectForBigUnit(string _file_name) => (string) null;

    [Token(Token = "0x6003BA3")]
    [Address(RVA = "0x10D3C00", Offset = "0x10D2A00", VA = "0x110D3C00")]
    public static string SkillScene(string sceneName) => (string) null;

    [Token(Token = "0x6003BA4")]
    [Address(RVA = "0x10D3CC0", Offset = "0x10D2AC0", VA = "0x110D3CC0")]
    public static string TrickEffect(string effect_name) => (string) null;

    [Token(Token = "0x6003BA5")]
    [Address(RVA = "0x10D3D80", Offset = "0x10D2B80", VA = "0x110D3D80")]
    public static string TrickIconUI(string marker_name) => (string) null;

    [Token(Token = "0x6003BA6")]
    [Address(RVA = "0x10D5820", Offset = "0x10D4620", VA = "0x110D5820")]
    public static string WeatherIcon(string icon_name) => (string) null;

    [Token(Token = "0x6003BA7")]
    [Address(RVA = "0x10D5760", Offset = "0x10D4560", VA = "0x110D5760")]
    public static string WeatherEffect(string effect_name) => (string) null;

    [Token(Token = "0x6003BA8")]
    [Address(RVA = "0x10D55C0", Offset = "0x10D43C0", VA = "0x110D55C0")]
    public static string UnitVoiceFileName(UnitParam unit, ArtifactParam artifact = null, string jobVoice = "")
    {
      return (string) null;
    }

    [Token(Token = "0x6003BA9")]
    [Address(RVA = "0x10D27C0", Offset = "0x10D15C0", VA = "0x110D27C0")]
    public static string ArtifactIcon(ArtifactParam arti) => (string) null;

    [Token(Token = "0x6003BAA")]
    [Address(RVA = "0x10D2CD0", Offset = "0x10D1AD0", VA = "0x110D2CD0")]
    public static string ConceptCardIcon(ConceptCardParam card) => (string) null;

    [Token(Token = "0x6003BAB")]
    [Address(RVA = "0x10D2DA0", Offset = "0x10D1BA0", VA = "0x110D2DA0")]
    public static string ConceptCard(ConceptCardParam card) => (string) null;

    [Token(Token = "0x6003BAC")]
    [Address(RVA = "0x10D2E70", Offset = "0x10D1C70", VA = "0x110D2E70")]
    public static string ConceptCard(string path) => (string) null;

    [Token(Token = "0x6003BAD")]
    [Address(RVA = "0x10D3070", Offset = "0x10D1E70", VA = "0x110D3070")]
    public static string Highlight(string path) => (string) null;

    [Token(Token = "0x6003BAE")]
    [Address(RVA = "0x10D2960", Offset = "0x10D1760", VA = "0x110D2960")]
    public static string BondGroupGB(string path) => (string) null;

    [Token(Token = "0x6003BAF")]
    [Address(RVA = "0x10D3EB0", Offset = "0x10D2CB0", VA = "0x110D3EB0")]
    public static string TruthEquipmentIcon(string iconName) => (string) null;

    [Token(Token = "0x6003BB0")]
    [Address(RVA = "0x10D2F30", Offset = "0x10D1D30", VA = "0x110D2F30")]
    public static string CrystalIcon(string _path) => (string) null;

    [Token(Token = "0x6003BB1")]
    [Address(RVA = "0x10D58E0", Offset = "0x10D46E0", VA = "0x110D58E0")]
    static AssetPath()
    {
    }
  }
}
