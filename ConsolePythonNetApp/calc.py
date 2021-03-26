class myMatch:
    @staticmethod
    def calc(math_str=""):
        if myMatch.check(math_str):
            return eval(math_str)
        else:
            return False

    @staticmethod
    def check(math=""):
        if isinstance(math, str):
            for char in math:
                if not (char in '0987654321 -=+^.!*/()'):
                    return False
        else:
            return False
        return True


if __name__ == "__main__":
    print(myMatch.calc())
