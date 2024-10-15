// Decompiled with JetBrains decompiler
// Type: SRPG.UnitKakusei
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C68")]
  [AddComponentMenu("UI/UnitKakusei")]
  public class UnitKakusei : MonoBehaviour
  {
    [Token(Token = "0x400DBD9")]
    [FieldOffset(Offset = "0xC")]
    public GameObject JobUnlock;
    [Token(Token = "0x400DBDA")]
    [FieldOffset(Offset = "0x10")]
    public GameObject[] JobUnlocks;
    [Token(Token = "0x400DBDB")]
    [FieldOffset(Offset = "0x14")]
    public JobParam UnlockJobParam;
    [Token(Token = "0x400DBDC")]
    [FieldOffset(Offset = "0x18")]
    public JobParam[] UnlockJobParams;
    [Token(Token = "0x400DBDD")]
    [FieldOffset(Offset = "0x1C")]
    public Text LevelValue;
    [Token(Token = "0x400DBDE")]
    [FieldOffset(Offset = "0x20")]
    public Text CombValue;

    [Token(Token = "0x17001B27")]
    public int UpdateLevelValue
    {
      [Token(Token = "0x600CDBE"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x600CDBF"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] set
      {
      }
    }

    [Token(Token = "0x17001B28")]
    public int UpdateCombValue
    {
      [Token(Token = "0x600CDC0"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
      [Token(Token = "0x600CDC1"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] set
      {
      }
    }

    [Token(Token = "0x600CDC2")]
    [Address(RVA = "0x989BE0", Offset = "0x9889E0", VA = "0x10989BE0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600CDC3")]
    [Address(RVA = "0x989CA0", Offset = "0x988AA0", VA = "0x10989CA0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CDC4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitKakusei()
    {
    }
  }
}
