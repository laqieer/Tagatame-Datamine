// Decompiled with JetBrains decompiler
// Type: SRPG.GachaDropAnimationParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200240A")]
  [AddComponentMenu("UI/Gacha/GachaDropAnimationParts")]
  public class GachaDropAnimationParts : MonoBehaviour
  {
    [Token(Token = "0x400A2F2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject[] DropObjs;

    [Token(Token = "0x6009CE3")]
    [Address(RVA = "0x600790", Offset = "0x5FF590", VA = "0x10600790")]
    private void ResetObj()
    {
    }

    [Token(Token = "0x6009CE4")]
    [Address(RVA = "0x600A30", Offset = "0x5FF830", VA = "0x10600A30")]
    public void Setup(GameObject drop_object)
    {
    }

    [Token(Token = "0x6009CE5")]
    [Address(RVA = "0x600850", Offset = "0x5FF650", VA = "0x10600850")]
    public void Setup(GameObject[] drop_objects, GachaDropData[] drops)
    {
    }

    [Token(Token = "0x6009CE6")]
    [Address(RVA = "0x600B50", Offset = "0x5FF950", VA = "0x10600B50")]
    public void Setup(GachaDropData[] drops)
    {
    }

    [Token(Token = "0x6009CE7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaDropAnimationParts()
    {
    }
  }
}
