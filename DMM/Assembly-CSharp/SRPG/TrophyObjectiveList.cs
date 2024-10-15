// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyObjectiveList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B7B")]
  [AddComponentMenu("UI/TrophyObjectiveList")]
  public class TrophyObjectiveList : MonoBehaviour
  {
    [Token(Token = "0x400D506")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Item_Complete;
    [Token(Token = "0x400D507")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Item_Incomplete;

    [Token(Token = "0x600C768")]
    [Address(RVA = "0x900F10", Offset = "0x8FFD10", VA = "0x10900F10", Slot = "4")]
    public virtual void Start()
    {
    }

    [Token(Token = "0x600C769")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TrophyObjectiveList()
    {
    }
  }
}
