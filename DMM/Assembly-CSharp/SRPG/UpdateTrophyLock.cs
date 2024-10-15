// Decompiled with JetBrains decompiler
// Type: SRPG.UpdateTrophyLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018CE")]
  public class UpdateTrophyLock
  {
    [Token(Token = "0x4005977")]
    [FieldOffset(Offset = "0x8")]
    private int lock_count;

    [Token(Token = "0x170009CA")]
    public bool IsLock
    {
      [Token(Token = "0x600637E"), Address(RVA = "0x319770", Offset = "0x318570", VA = "0x10319770")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600637F")]
    [Address(RVA = "0x319710", Offset = "0x318510", VA = "0x10319710")]
    public void LockClear()
    {
    }

    [Token(Token = "0x6006380")]
    [Address(RVA = "0x319740", Offset = "0x318540", VA = "0x10319740")]
    public void Lock()
    {
    }

    [Token(Token = "0x6006381")]
    [Address(RVA = "0x319750", Offset = "0x318550", VA = "0x10319750")]
    public void Unlock()
    {
    }

    [Token(Token = "0x6006382")]
    [Address(RVA = "0x2B6250", Offset = "0x2B5050", VA = "0x102B6250")]
    public UpdateTrophyLock()
    {
    }
  }
}
