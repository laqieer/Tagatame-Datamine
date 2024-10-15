// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardUnitImageSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E99")]
  public class ConceptCardUnitImageSettings : ScriptableObject
  {
    [Token(Token = "0x4002CD9")]
    private const string ASSET_NAME = "ConceptCardSettings/ConceptCardUnitImageSettings";
    [Token(Token = "0x4002CDA")]
    [FieldOffset(Offset = "0xC")]
    public UnitImageSetting UnitImageSetting;
    [Token(Token = "0x4002CDB")]
    [FieldOffset(Offset = "0x0")]
    private static ConceptCardUnitImageSettings mInstance;

    [Token(Token = "0x170004B9")]
    public static ConceptCardUnitImageSettings Instance
    {
      [Token(Token = "0x6003CC6"), Address(RVA = "0x10F1D80", Offset = "0x10F0B80", VA = "0x110F1D80")] get
      {
        return (ConceptCardUnitImageSettings) null;
      }
    }

    [Token(Token = "0x6003CC7")]
    [Address(RVA = "0x10F1740", Offset = "0x10F0540", VA = "0x110F1740")]
    public static void ComposeUnitConceptCardImage(
      ConceptCardParam param,
      RawImage bgImage,
      GameObject imageTemplate,
      GameObject msg,
      Text msgText)
    {
    }

    [Token(Token = "0x6003CC8")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public ConceptCardUnitImageSettings()
    {
    }
  }
}
