// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustThirdPartySharing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036E2")]
  public class AdjustThirdPartySharing
  {
    [Token(Token = "0x4010231")]
    [FieldOffset(Offset = "0x8")]
    internal bool? isEnabled;
    [Token(Token = "0x4010232")]
    [FieldOffset(Offset = "0xC")]
    internal Dictionary<string, List<string>> granularOptions;
    [Token(Token = "0x4010233")]
    [FieldOffset(Offset = "0x10")]
    internal Dictionary<string, List<string>> partnerSharingSettings;

    [Token(Token = "0x600F939")]
    [Address(RVA = "0xB690F0", Offset = "0xB67EF0", VA = "0x10B690F0")]
    public AdjustThirdPartySharing(bool? isEnabled)
    {
    }

    [Token(Token = "0x600F93A")]
    [Address(RVA = "0xB691A0", Offset = "0xB67FA0", VA = "0x10B691A0")]
    public void addGranularOption(string partnerName, string key, string value)
    {
    }

    [Token(Token = "0x600F93B")]
    [Address(RVA = "0xB692C0", Offset = "0xB680C0", VA = "0x10B692C0")]
    public void addPartnerSharingSetting(string partnerName, string key, bool value)
    {
    }
  }
}
