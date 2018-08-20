using ListDiff;
using Xunit;

namespace ListDiffTests
{
	public class Tests {
		[Theory]
		[InlineData ("", "", "")]
		[InlineData ("a", "a", "a")]
		[InlineData ("a", "b", "-(a)+(b)")]
		[InlineData ("ab", "ab", "ab")]
		[InlineData ("abc", "ab", "ab-(c)")]
		[InlineData ("ab", "abc", "ab+(c)")]
		public void SimpleCases (string left, string right, string expectedDiff) {
			var diff = left.Diff (right);
			Assert.Equal (expectedDiff, diff.ToString ());
		}

		[Fact]
		public void Insert () {
			var source = "ac";
			var destination = "abc";
			var diff = source.Diff (destination);
		}
	}
}
