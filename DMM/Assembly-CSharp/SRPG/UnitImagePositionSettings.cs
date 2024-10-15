// Decompiled with JetBrains decompiler
// Type: SRPG.UnitImagePositionSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C38")]
  public class UnitImagePositionSettings : ScriptableObject
  {
    [Token(Token = "0x400DAF4")]
    private const string RESOURCE_PATH = "UI/UnitInventory/UnitImagePositionSettings";
    [Token(Token = "0x400DAF5")]
    [FieldOffset(Offset = "0xC")]
    [HideInInspector]
    [SerializeField]
    private UnitImagePositionSettings.UnitImagePosition[] m_UnitImagePositions;
    [Token(Token = "0x400DAF6")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, UnitImagePositionSettings.UnitImagePosition> m_UnitImagePositionDic;

    [Token(Token = "0x600CCD4")]
    [Address(RVA = "0x979CC0", Offset = "0x978AC0", VA = "0x10979CC0")]
    private void InitializeDic()
    {
    }

    [Token(Token = "0x600CCD5")]
    [Address(RVA = "0x979B00", Offset = "0x978900", VA = "0x10979B00")]
    private static string CreateSearchKey(string unitID, string skinID) => (string) null;

    [Token(Token = "0x600CCD6")]
    [Address(RVA = "0x979B50", Offset = "0x978950", VA = "0x10979B50")]
    private static string CreateSearchKey(
      UnitImagePositionSettings.UnitImagePosition posData)
    {
      return (string) null;
    }

    [Token(Token = "0x600CCD7")]
    [Address(RVA = "0x979A90", Offset = "0x978890", VA = "0x10979A90")]
    private static string CreateSearchKey(UnitParam unitParam, ArtifactParam skinParam)
    {
      return (string) null;
    }

    [Token(Token = "0x600CCD8")]
    [Address(RVA = "0x979BB0", Offset = "0x9789B0", VA = "0x10979BB0")]
    public bool GetUnitImagePosition(UnitParam unitParam, ArtifactParam skinParam, ref Vector2 pos)
    {
      return new bool();
    }

    [Token(Token = "0x600CCD9")]
    [Address(RVA = "0x979F10", Offset = "0x978D10", VA = "0x10979F10")]
    public static LoadRequest LoadAsync() => (LoadRequest) null;

    [Token(Token = "0x600CCDA")]
    [Address(RVA = "0x979F70", Offset = "0x978D70", VA = "0x10979F70")]
    public static UnitImagePositionSettings Load() => (UnitImagePositionSettings) null;

    [Token(Token = "0x600CCDB")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public UnitImagePositionSettings()
    {
    }

    [Token(Token = "0x2002C39")]
    [Serializable]
    public class UnitImagePosition
    {
      [Token(Token = "0x400DAF7")]
      [FieldOffset(Offset = "0x8")]
      public string m_Iname;
      [Token(Token = "0x400DAF8")]
      [FieldOffset(Offset = "0xC")]
      public string m_SkinAsset;
      [Token(Token = "0x400DAF9")]
      [FieldOffset(Offset = "0x10")]
      public Vector2 m_Position;

      [Token(Token = "0x600CCDC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitImagePosition()
      {
      }
    }
  }
}
