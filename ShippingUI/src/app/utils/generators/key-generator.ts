export default class KeyGenerator {
    static generate() {
        return btoa(Math.random().toString());
    }
}